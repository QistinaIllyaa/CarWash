using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarWash.Data;
using CarWash.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarWash.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly CarWashContext _context;

        private object _httpContextAccessor;

        public ReservationsController(CarWashContext context)
        {
            _context = context;
        }
        
        //public async Task<IActionResult> Index(string id)
        //{
        //    var reservation = from m in _context.Reservation
        //                      select m;

        //    if (!String.IsNullOrEmpty(id))
        //    {
        //        reservation = reservation.Where(s => s.Address.Contains(id));
        //    }

        //    return View(await _context.Reservation.ToListAsync());
        //}
        //forstaff
        public async Task<IActionResult> Index()
        {

            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var reservation = _context.Reservation
                .Include(r => r.Car)
                 .ThenInclude(s => s.User)
                .Include(r => r.Types)
                .Where(x => x.Car.UserId == userId)
                .ToList();



            return View(await _context.Reservation.Where(x => x.Car.UserId == userId).ToListAsync());
        }



        public string DateSort { get; set; }
        //Ni list semua reservation untuk admin
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetReservation(int id, string sortOrder)
        {

            var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["IdSortParm"] = String.IsNullOrEmpty(sortOrder) ? "id_decs" : "";
            var reservation = _context.Reservation
                .Include(r => r.Car)
                .Include(r => r.Types)
                .FirstOrDefault();
            var reserve = _context.Reservation.AsQueryable();

            switch (sortOrder)
            {

                case "Date":
                    reserve = reserve.OrderByDescending(s => s.Date);
                    break;
                default:
                    reserve = reserve.OrderBy(s => s.Id);
                    break;
            }
                    return View(await _context.Reservation.OrderByDescending(x => x.Date).ToListAsync());
        }

        //[Route("reservations/create/car/{carid}")]
        public IActionResult Create(int carid)
        {
            ViewBag.CarId = carid;
            return View();
        }

        //[Route("reservations/create/car/{carid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reservationModel)
        {
            if (ModelState.IsValid)
            {

                var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var car = _context.Car.Where(x => x.Id == reservationModel.CarId).FirstOrDefault();
                var type = _context.Types.Where(x => x.Id == reservationModel.TypesId).FirstOrDefault();
                double Prices = type.Prices;
                string CarType = car.CarType;
                int TypeId = type.Id;
                double Amount = reservationModel.Amount;

                if(CarType == "Sedan")
                {
                   if(TypeId == 22)
                    {
                        Amount += Prices;
                        if (reservationModel.Vacuum)
                        {
                            Amount += Prices + 2;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Amortires)
                        {
                            Amount += Prices + 2;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                    else if (TypeId == 23)
                    {
                        Amount += Prices;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Enginewash)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }

                    else 
                    {
                        Amount += Prices;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                         else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                }

                else if (CarType == "MPV")
                {
                   
                    if (TypeId == 22)
                    {
                        Amount += Prices+2 ;
                        if (reservationModel.Vacuum)
                        {
                            Amount += Prices + 2;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Amortires)
                        {
                            Amount += Prices + 3;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                    else if (TypeId == 23)
                    {
                       
                        Amount += Prices+3;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Enginewash)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }

                    else
                    {

                        Amount += Prices+1;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                }

                else if (CarType == "SUV")
                {
                   
                    if (TypeId == 22)
                    {
                        Amount += Prices+4;
                        if (reservationModel.Vacuum)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Amortires)
                        {
                            Amount += Prices + 2;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                    else if (TypeId == 23)
                    {

                        Amount += Prices+5;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 5;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Enginewash)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }

                    else
                    {

                        Amount += Prices+5;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 5;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                }

                else if (CarType == "Hatchback")
                { 
                    if (TypeId == 22)
                    {
                        Amount += Prices;
                        if (reservationModel.Vacuum)
                        {
                            Amount += Prices + 2;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Amortires)
                        {
                            Amount += Prices + 2;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                    else if (TypeId == 23)
                    {
                        Amount += Prices;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Enginewash)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }

                    else
                    {
                        Amount += Prices;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                }

                else if (CarType == "Convertible")
                {
                   
                    if (TypeId == 22)
                    {
                        Amount += Prices+6;
                        if (reservationModel.Vacuum)
                        {
                            Amount += Prices + 4;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Amortires)
                        {
                            Amount += Prices + 2;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                    else if (TypeId == 23)
                    {

                        Amount += Prices+5;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 5;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Enginewash)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += (Prices + 2);
                        }
                    }
                    
                    else
                    {

                        Amount += Prices+10;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 5;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                }

                else 
                {
                    if (TypeId == 22)
                    {
                        Amount += Prices+6;
                        if (reservationModel.Vacuum)
                        {
                            Amount += Prices + 2;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Amortires)
                        {
                            Amount += Prices + 2;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }
                    else if (TypeId == 23)
                    {
                        Amount += Prices+5;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 6;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Enginewash)
                        {
                            Amount += Prices + 5;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount += Prices + 2;
                        }
                    }

                    else
                    {
                        Amount += Prices+10;
                        if (reservationModel.Leatherconditioner)
                        {
                            Amount += Prices + 6;
                        }

                        else if (reservationModel.Polish)
                        {
                            Amount += Prices + 8;
                        }
                        else if (reservationModel.Freshner)
                        {
                            Amount = Prices + 2;
                        }
                    }
                };


                var reservation = new Reservation();
                {
                    reservation.Id = reservationModel.Id;
                    reservation.Address = reservationModel.Address;
                    reservation.Latitude = reservationModel.Latitude;
                    reservation.Longitude = reservationModel.Longitude;
                    reservation.Date = reservationModel.Date;
                    reservation.Day = reservationModel.Day;
                    reservation.Amount = Amount;
                    reservation.Vacuum = reservationModel.Vacuum;
                    reservation.Polish = reservationModel.Polish;
                    reservation.Freshner = reservationModel.Freshner;
                    reservation.Amortires = reservationModel.Amortires;
                    reservation.Enginewash = reservationModel.Enginewash;
                    reservation.Leatherconditioner = reservationModel.Leatherconditioner;
                    reservation.CarId = reservationModel.CarId;
                    reservation.TypesId = reservationModel.TypesId;
                    reservation.Payment = reservationModel.Payment;
                    reservation.Answer = reservationModel.Answer;
                    reservation.Comment = reservationModel.Comment;

                };

               

                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ReservationsController.Confirmation), "Reservations");


            }
            return View(reservationModel);
        }

        public async Task<IActionResult> Confirmation()
        {
            return View();
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Car)
                .Include(r => r.Types)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }


        // GET: Reservations/Edit/5
        [Authorize(Roles = "Administrator, Staff, Visitor")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["CarId"] = new SelectList(_context.Car, "Id", "CarNo", reservation.CarId);
            ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Services", reservation.TypesId);
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator, Staff, Visitor")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Address,Date,Day,Amount,Vacuum,Leatherconditioner,Polish,Freshner,Amortires,Enginewash,CarId,TypesId,Payment,Answer,Comment,Latitude,Longitude")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ReservationsController.GetReservation), "Reservations");
            }
            ViewData["CarId"] = new SelectList(_context.Car, "Id", "CarNo", reservation.CarId);
            ViewData["TypesId"] = new SelectList(_context.Types, "Id", "Services", reservation.TypesId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Car)
                .Include(r => r.Types)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }
        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ReservationsController.GetReservation), "Reservations");
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.Id == id);
        }

       
    }
}
