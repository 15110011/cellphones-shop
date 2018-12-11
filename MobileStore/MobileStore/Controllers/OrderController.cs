using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using MobileStore.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace MobileStore.Controllers
{
    public class OrderController:Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;      
        private readonly Order _order;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;            
        }

        public IActionResult Checkout()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var checkoutCartViewModel = new CheckoutViewModel
            {
                Order = _order,
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
            return View(checkoutCartViewModel);
        }

        [HttpPost]   
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }            
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);                
                return RedirectToAction("CheckoutComplete");
            }
            var checkoutCartViewModel = new CheckoutViewModel
            {
                Order = _order,
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
            return View(checkoutCartViewModel);
        }
        public IActionResult CheckoutComplete()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;            
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            var checkoutCartViewModel = new CheckoutViewModel
            {
                Order = _order,
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
            _shoppingCart.ClearCart();
            return View(checkoutCartViewModel);
        }

    }
}
