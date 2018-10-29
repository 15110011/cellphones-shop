using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Interfaces;
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

        public ViewResult List()
        {
            var phones = _phoneRepository.Phones;
            return View(phones);  
        }


    }
    
}
