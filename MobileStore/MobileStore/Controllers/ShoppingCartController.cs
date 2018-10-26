using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
=======
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using MobileStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
>>>>>>> 0031e1ddccc8541fe0a595a4de53d4afab708f88

namespace MobileStore.Controllers
{
    public class ShoppingCartController : Controller
    {
<<<<<<< HEAD
        public IActionResult Index()
        {
            return View();
        }
    }
}
=======
        private readonly IPhoneRepository _phoneRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPhoneRepository phoneRepository,ShoppingCart shoppingCart)
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
>>>>>>> 0031e1ddccc8541fe0a595a4de53d4afab708f88
