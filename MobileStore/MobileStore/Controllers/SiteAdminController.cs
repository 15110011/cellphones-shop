using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MobileStore.Controllers
{
    public class SiteAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}