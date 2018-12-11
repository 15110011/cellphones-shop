using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MobileStore.Controllers
{
    public class ContactController : Controller
    {
        public ViewResult Index()
        {
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
            return View();
        }
    }
}