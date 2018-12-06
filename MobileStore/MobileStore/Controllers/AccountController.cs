using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MobileStore.ViewModels;

namespace MobileStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;        
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

       public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel() {  
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
                return View(loginViewModel);

            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
           
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                    {
                        var bf = new BinaryFormatter();

                        var ms = new MemoryStream();
                        bf.Serialize(ms, user.ToString());

                        HttpContext.Session.Set("login", ms.ToArray());
                        ms.Dispose();
                        return RedirectToAction("Index", "Home");
                    }
                   

                    return Redirect(loginViewModel.ReturnUrl);
                }
            }
            ModelState.AddModelError("", "Username/password not found");
            return View(loginViewModel);
        }

        public IActionResult Register() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = loginViewModel.UserName };
                var result = await _userManager.CreateAsync(user, loginViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("LoggedIn", "Account");
                }
            }
            return View(loginViewModel);
        }
        public ViewResult LoggedIn() => View();

        [HttpPost]        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            var bf = new BinaryFormatter();

            var ms = new MemoryStream();
            bf.Serialize(ms, "");

            HttpContext.Session.Set("login", ms.ToArray());
            ms.Dispose();

            return RedirectToAction("Index", "Home");
        }
    }
}