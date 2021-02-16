using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarWash.Data;
using CarWash.Models;
using System.Security.Claims;

namespace CarWash.Controllers
{
    public class TypesController : Controller
    {
        private readonly CarWashContext _context;

        public TypesController(CarWashContext context)
        {
            _context = context;
        }

        // GET: Types
        public async Task<IActionResult> Index()
        {
            return View(await _context.Types.ToListAsync());
        }

        // GET: Types/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var types = await _context.Types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (types == null)
            {
                return NotFound();
            }

            return View(types);
        }

        // GET: Types/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Types/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Services,Prices")] Types types)
        {
            if (ModelState.IsValid)
            {
                var userId = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var type = new Types();
                {
                    type.Id = types.Id;
                }
              
                _context.Add(types);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TypesController.Index), "Types");
            }
            return View(types);
        }

        // GET: Types/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var types = await _context.Types.FindAsync(id);
            if (types == null)
            {
                return NotFound();
            }
            return View(types);
        }

        // POST: Types/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Services,Prices")] Types types)
        {
            if (id != types.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(types);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypesExists(types.Id))
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
            return View(types);
        }

        // GET: Types/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var types = await _context.Types
                .FirstOrDefaultAsync(m => m.Id == id);
            if (types == null)
            {
                return NotFound();
            }

            return View(types);
        }

        // POST: Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var types = await _context.Types.FindAsync(id);
            _context.Types.Remove(types);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypesExists(int id)
        {
            return _context.Types.Any(e => e.Id == id);
        }

        [Route("types/select2")]
        public async Task<IActionResult> Select2([FromQuery(Name = "term")] string search, [FromQuery(Name = "page")] int page, string code)
        {
            var more = false;
            var query = _context.Types.AsQueryable();

            var totalQuery = query;
            var totalCount = totalQuery.Count();

            //if (!string.IsNullOrEmpty(search))
            //{

            //    query = query.Where(x => x.Services.ToLower().Contains(search.ToLower()));
            //}

            var length = 10;
            var start = (page - 1) * length;

            var totalPage = (int)Math.Ceiling((double)totalCount / length);

            more = totalPage > page;

            var data = await query.OrderBy(x => x.Services)
                .Select(x => new Select2ViewModel() { text = x.Services, id = x.Id.ToString() })
                .Skip(start)
                .Take(length)
                .ToListAsync();

            return Json(new { results = data, pagination = new { more = more } });
        }

    }
}
