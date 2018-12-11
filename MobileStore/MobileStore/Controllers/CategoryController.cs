using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            return View(categories);
        }
    }
}