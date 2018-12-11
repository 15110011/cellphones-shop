 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using MobileStore.ViewModels;



namespace MobileStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPhoneRepository _phoneRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPhoneRepository phoneRepository, ShoppingCart shoppingCart)
        {
            _phoneRepository = phoneRepository;
            _shoppingCart = shoppingCart;
        }
              
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            if (HttpContext.Session.TryGetValue("login", out var data))
            {
                var bf = new BinaryFormatter();

                string strData;
                using (var ms = new MemoryStream(data))
                {
                    strData = bf.Deserialize(ms) as string;
                }
                if (strData.Length >= 2)
                {
                    ViewBag.Status = true;
                    ViewBag.username = strData;
                }
                else
                    ViewBag.Status = false;

            }
            return View(shoppingCartViewModel);
        }
        
        public RedirectToActionResult AddToShoppingCart(int phoneId)
        {
            var selectedPhone = _phoneRepository.Phones.FirstOrDefault(p => p.PhoneId == phoneId);
            if (selectedPhone != null)
            {
                _shoppingCart.AddToCart(selectedPhone, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int phoneId)
        {
            var selectedPhone = _phoneRepository.Phones.FirstOrDefault(p => p.PhoneId == phoneId);
            if (selectedPhone != null)
            {
                _shoppingCart.RemoveFromCart(selectedPhone);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearFromShoppingCart(int cartId)
        {
            _shoppingCart.ClearCart();
          
            return RedirectToAction("Index");
        }

    }
}
