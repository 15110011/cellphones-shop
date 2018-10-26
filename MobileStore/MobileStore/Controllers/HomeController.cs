using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Interfaces;
using MobileStore.Models;

namespace MobileStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPhoneRepository _phoneRepository;
        public HomeController(ICategoryRepository categoryRepository, IPhoneRepository phoneRepository)
        {
            _categoryRepository = categoryRepository;
            _phoneRepository = phoneRepository;
        }
        public IActionResult Index()
        {
            var phones = _phoneRepository.Phones;
            return View(phones);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
