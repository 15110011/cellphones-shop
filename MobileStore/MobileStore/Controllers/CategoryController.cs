using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileStore.Data.Interfaces;

namespace MobileStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public ViewResult Index()
        {
            var categories = _categoryRepository.Categories;
            return View(categories);
        }
    }
}