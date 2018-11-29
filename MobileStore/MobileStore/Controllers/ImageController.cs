using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;                    //*Directory
using Microsoft.AspNetCore.Http;    //*IFormFile
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting; //*get RootPath

namespace MobileStore.Controllers
{
    public class ImageController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;

        public ImageController(IHostingEnvironment appEnvironment)

        {

            //----< Init: Controller >----

            _appEnvironment = appEnvironment;

            //----</ Init: Controller >----

        }







        [HttpGet] //1.Load

        public IActionResult Upload_Image()

        {

            //--< Upload Form >--

            return View();

            //--</ Upload Form >--

        }





        [HttpPost] //Postback

        public async Task<IActionResult> Upload_Image(IFormFile file)

        {

            //--------< Upload_ImageFile() >--------

            //< check >

            if (file == null || file.Length == 0) return Content("file not selected");

            //</ check >



            //< get Path >

            string path_Root = _appEnvironment.WebRootPath;

            string path_to_Images = path_Root + "\\images\\" + file.FileName;

            //</ get Path >



            //< Copy File to Target >

            using (var stream = new FileStream(path_to_Images, FileMode.Create))

            {

                await file.CopyToAsync(stream);

            }

            //</ Copy File to Target >



            //< output >

            ViewData["FilePath"] = path_to_Images;

            return View();

            //</ output >

            //--------</ Upload_ImageFile() >--------

        }
    }
}
