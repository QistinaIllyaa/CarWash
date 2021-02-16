using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarWash.Data;
using CarWash.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CarWash.Controllers
{
    public class UsersController : Controller
    {
        private readonly CarWashContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<UsersController> _logger;

        public UsersController(CarWashContext context, ILogger<UsersController> logger, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        public async Task<IActionResult> Index(User userModel)
        {
            string CarNo = userModel.CarNo;

            if(CarNo == null)
            {
                return View(await _context.User.Where(x => x.CarNo == CarNo).ToListAsync());
            }
            else
            {
                return NotFound();
            }
        }

        public async Task<IActionResult> Customer(User userModel)
        {
           return View(await _context.User.Where(x => x.CarNo != null).ToListAsync());
        }

        // GET: Cars/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.Users
                .Include(x => x.Car).ThenInclude(y => y.Reservation)
                 .FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var vm = new User();
            vm.Id = user.Id;
            vm.Name = user.Name;
            vm.UserName = user.UserName;
            vm.Email = user.Email;
            vm.CarNo = user.CarNo;
            vm.CarType = user.CarType;
            vm.Colour = user.Colour;


            return View(vm);
        }


        // POST: Types/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, User vm)
        {

            try
            {
                var user = await _userManager.Users
               .Include(x => x.Car).ThenInclude(y => y.Reservation)
                .FirstOrDefaultAsync(x => x.Id == id);

                if (user == null)
                {
                    return RedirectToAction(nameof(Index));
                }
                
                user.Name = vm.Name;
                user.UserName = vm.UserName;
                user.Email = vm.Email;
                user.CarNo = vm.CarNo;
                user.CarType = vm.CarType;
                user.Colour = vm.Colour;

                await _userManager.UpdateAsync(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", "Users", new { area = "" });
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }

            return View(vm);
        }


        private bool UserExists(string id)
        {
            return _context.User.Any(e => e.Id == id);
        }


        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.User.FindAsync(id);
            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Viewstaff()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            return View();
        }
    }
}