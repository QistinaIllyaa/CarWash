using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CarWash.Data;
using CarWash.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarWash.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
       
        public AccountController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
           
        }


        //RegisterCustomer
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            //var user = _mapper.Map<User>(userModel);
            var user = new User
            {
                UserName = userModel.Email,
                Name = userModel.Name,
                Email = userModel.Email,
                CarNo = userModel.CarNo,
                CarType = userModel.CarType,
                Colour = userModel.CarColor
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(userModel);
            }

            await _userManager.AddToRoleAsync(user, "Visitor");

            return RedirectToAction(nameof(AccountController.Login), "Account");
        }

        //RegisterStaff
        [Route("registerstaff")]
        [HttpGet]
        public IActionResult RegisterStaff()
        {
            return View();
        }

        [Route("registerstaff")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterStaff(UserRegistrationModel users)
        {
            if (!ModelState.IsValid)
            {
                return View(users);
            }

            //var user = _mapper.Map<User>(userModel);
            var user = new User
            {
                UserName = users.Email,
                Name = users.Name,
                Email = users.Email,
               
            };

            var result = await _userManager.CreateAsync(user, users.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(users);
            }

            await _userManager.AddToRoleAsync(user, "Staff");

            return RedirectToAction(nameof(AfterloginController.Afterloginhome), "Afterlogin");
        }


        //LoginCustomer
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel userModel, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            var result = await _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, userModel.RememberMe, false);
            if (result.Succeeded)
            {
                
                    return RedirectToLocal(returnUrl);
               
                
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }


        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else
                return RedirectToAction(nameof(AfterloginController.Afterloginhome), "Afterlogin");

        }



        //LogoutCustomer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

      

        
    }
}