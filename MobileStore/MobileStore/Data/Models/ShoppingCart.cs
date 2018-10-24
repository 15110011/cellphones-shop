using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Models
{
    public class ShoppingCart
    {
        private readonly MobileStoreDbContext _mobileStoreDbContext;
        private ShoppingCart(MobileStoreDbContext mobileStoreDbContext)
        {
            _mobileStoreDbContext = mobileStoreDbContext;
        }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<MobileStoreDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Phone phone, int amount)
        {
            var shoppingCartItem =
                    _mobileStoreDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Phone.PhoneId == phone.PhoneId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Phone = phone,
                    Amount = 1
                };

                _mobileStoreDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _mobileStoreDbContext.SaveChanges();
        }

        public int RemoveFromCart(Phone phone)
        {
            var shoppingCartItem =
                    _mobileStoreDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Phone.PhoneId == phone.PhoneId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _mobileStoreDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _mobileStoreDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _mobileStoreDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Phone)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _mobileStoreDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _mobileStoreDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _mobileStoreDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _mobileStoreDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Phone.Price * c.Amount).Sum();
            return total;
        }
    }
}
