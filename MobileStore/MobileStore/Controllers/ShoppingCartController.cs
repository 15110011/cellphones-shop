using System;
using System.Collections.Generic;
using System.Linq;
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
        // GET: /<controller>/
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(sCVM);
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
    }      
}
