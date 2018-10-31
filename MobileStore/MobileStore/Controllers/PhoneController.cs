using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Interfaces;
using MobileStore.Data.Models;
using MobileStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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


            return View(new PhonesListViewModel
            {
                Phones = phones,
                CurrentCategory= currentCategory             
            });
        }


    }
    
}
