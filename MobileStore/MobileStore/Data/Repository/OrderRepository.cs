using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly MobileStoreDbContext _mobileStoreDbContext;
        private readonly ShoppingCart _shoppingCart;
        public OrderRepository(MobileStoreDbContext mobileStoreDbContext,ShoppingCart shoppingCart)
        {
            _mobileStoreDbContext = mobileStoreDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _mobileStoreDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    PhoneId = item.Phone.PhoneId,
                    OrderId = order.OrderId,
                    Price = item.Phone.Price
                };

                _mobileStoreDbContext.OrderDetails.Add(orderDetail);
            }
            _mobileStoreDbContext.SaveChanges();
        }
    }
}
