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
    public class PhoneController : Controller {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPhoneRepository _phoneRepository;
        public PhoneController(ICategoryRepository categoryRepository, IPhoneRepository phoneRepository)
        {
            _categoryRepository = categoryRepository;
            _phoneRepository = phoneRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Phone> phones;
            IEnumerable<Category> categories;
            categories = _categoryRepository.Categories.OrderBy(c => c.CategoryName);
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                phones = _phoneRepository.Phones.OrderBy(p => p.PhoneId);
                currentCategory = "All Phones";
            }
            else
            {                
                    phones = _phoneRepository.Phones.Where(p => p.Category.CategoryName.Equals(_category)).OrderBy(p => p.Name);
                currentCategory = _category;
            }

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
            return View(new PhonesListViewModel
            {
                Phones = phones,
                CurrentCategory= currentCategory             
            });
        }

        public ViewResult Details(int phoneId)
        {
            var phone = _phoneRepository.Phones.FirstOrDefault(d => d.PhoneId == phoneId);
            if (phone == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
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
            return View(phone);
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Phone> phones;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                phones = _phoneRepository.Phones.OrderBy(p => p.PhoneId);
            }
            else
            {
                phones = _phoneRepository.Phones.Where(p => p.Name.ToLower().Contains(_searchString.ToLower())
                ||p.Category.CategoryName.ToLower().Contains(_searchString.ToLower()));                
            }
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
            return View("~/Views/Phone/List.cshtml", new PhonesListViewModel { Phones = phones, CurrentCategory = "All phones" });
        }
    }
    
}
