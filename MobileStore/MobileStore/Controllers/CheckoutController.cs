using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Models;
using MobileStore.ViewModels;

namespace MobileStore.Controllers
{
    public class CheckoutController : Controller
    {
        
        public ViewResult Index()
        {           
            return View();
        }
    }
}