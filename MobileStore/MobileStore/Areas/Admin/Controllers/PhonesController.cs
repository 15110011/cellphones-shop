using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MobileStore;
using MobileStore.Data.Models;

namespace MobileStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PhonesController : Controller
    {
        private readonly MobileStoreDbContext _context;
        private readonly IHostingEnvironment __appEnvironment;

        public PhonesController(MobileStoreDbContext context,IHostingEnvironment appEnvironment)
        {
            _context = context;
            __appEnvironment = appEnvironment;
        }

        // GET: Admin/Phones
        public async Task<IActionResult> Index()
        {
            var mobileStoreDbContext = _context.Phones.Include(p => p.Category);
            return View(await mobileStoreDbContext.ToListAsync());
        }

        // GET: Admin/Phones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phones
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.PhoneId == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        // GET: Admin/Phones/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Admin/Phones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create([Bind("PhoneId,Name,ShortDescription,Price,ImageUrl,ImageThumbnailUrl,IsPreferredPhone,CategoryId")] Phone phone, IFormFile file)
        {

            if (file == null || file.Length == 0) return Content("file not selected");
            if (ModelState.IsValid)
            {
                _context.Add(phone);

                //< get Path >

                string pathRoot = __appEnvironment.WebRootPath;

                string pathToImages = pathRoot + "\\images\\" + file.FileName;
                string imageUrl = "\\images\\" + file.FileName;
                //</ get Path >

                //< Copy File to Target >
                

                using (var stream = new FileStream(pathToImages, FileMode.Create))

                {
                    await file.CopyToAsync(stream);
                }
                //</ Copy File to Target >
                if (pathToImages != null)
                {
                    phone.ImageUrl = imageUrl;
                }
                //< output >

                ViewData["FilePath"] = imageUrl;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", phone.CategoryId);
            return View(phone);
        }

        // GET: Admin/Phones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phones.FindAsync(id);
            if (phone == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", phone.CategoryId);
            return View(phone);
        }

        // POST: Admin/Phones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhoneId,Name,ShortDescription,Price,ImageUrl,ImageThumbnailUrl,IsPreferredPhone,CategoryId")] Phone phone, IFormFile file)
        {
            if (id != phone.PhoneId)
            {
                return NotFound();
            }
            if (file == null || file.Length == 0) return Content("file not selected");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phone);
                    //< get Path >

                    string pathRoot = __appEnvironment.WebRootPath;

                    string pathToImages = pathRoot + "\\images\\" + file.FileName;
                    string imageUrl = "\\images\\" + file.FileName;
                    //</ get Path >

                    //< Copy File to Target >


                    using (var stream = new FileStream(pathToImages, FileMode.Create))

                    {
                        await file.CopyToAsync(stream);
                    }
                    //</ Copy File to Target >
                    if (pathToImages != null)
                    {
                        phone.ImageUrl = imageUrl;
                    }
                    //< output >

                    ViewData["FilePath"] = imageUrl;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhoneExists(phone.PhoneId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", phone.CategoryId);
            return View(phone);
        }

        // GET: Admin/Phones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phone = await _context.Phones
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.PhoneId == id);
            if (phone == null)
            {
                return NotFound();
            }

            return View(phone);
        }

        // POST: Admin/Phones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phone = await _context.Phones.FindAsync(id);
            _context.Phones.Remove(phone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhoneExists(int id)
        {
            return _context.Phones.Any(e => e.PhoneId == id);
        }

         //1.Load

        //public IActionResult Upload_Image()

        //{

        //    //--< Upload Form >--

        //    return View();

        //    //--</ Upload Form >--

        //}
       // [HttpPost] //Postback
        //public async Task<IActionResult> Upload_Image([FromForm]IFormFile file)

        //{

        //    //--------< Upload_ImageFile() >--------

        //    //< check >

        //    if (file == null || file.Length == 0) return Content("file not selected");

        //    //</ check >



        //    //< get Path >

        //    string pathRoot = __appEnvironment.WebRootPath;

        //    string pathToImages = pathRoot + "\\images\\" + file.FileName;

        //    //</ get Path >

        //    //< Copy File to Target >

        //    using (var stream = new FileStream(pathToImages, FileMode.Create))

        //    {
        //        await file.CopyToAsync(stream);
        //    }
        //    //</ Copy File to Target >

        //    //< output >

        //    ViewData["FilePath"] = pathToImages;

        //    return View("Create");
        //    //</ output >
        //    //--------</ Upload_ImageFile() >--------
        //}
    }
}

