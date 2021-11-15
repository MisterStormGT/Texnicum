using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Texnicum.Models;
using Texnicum.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Texnicum.Controllers
{
    [Authorize(Roles = "admin, registeredUser")]
    public class TypesOfTotalsController : Controller
    {
        private readonly AppCtx _context;
        private readonly UserManager<User> _userManager;

        public TypesOfTotalsController(
             AppCtx context,
             UserManager<User> user)
        {
            _context = context;
            _userManager = user;
        }

        // GET: TypesOfTotals
        public async Task<IActionResult> Index()
        {
            // находим информацию о пользователе, который вошел в систему по его имени
            IdentityUser user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            var appCtx = _context.TypesOfTotals
                .Include(i => i.User)
                .Where(w => w.IdUser == user.Id)
                .OrderBy(o => o.CertificateName);

            return View(await appCtx.ToListAsync());
        }

        // GET: TypesOfTotals/Details/5
        public async Task<IActionResult> Details(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfTotal = await _context.TypesOfTotals
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfTotal == null)
            {
                return NotFound();
            }

            return View(typeOfTotal);
        }

        // GET: TypesOfTotals/Create
        public IActionResult Create()
        {
            ViewData["IdUser"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: TypesOfTotals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CertificateName,IdUser")] TypesOfTotals typeOfTotal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeOfTotal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.Users, "Id", "Id", typeOfTotal.IdUser);
            return View(typeOfTotal);
        }

        // GET: TypesOfTotals/Edit/5
        public async Task<IActionResult> Edit(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfTotal = await _context.TypesOfTotals.FindAsync(id);
            if (typeOfTotal == null)
            {
                return NotFound();
            }
            ViewData["IdUser"] = new SelectList(_context.Users, "Id", "Id", typeOfTotal.IdUser);
            return View(typeOfTotal);
        }

        // POST: TypesOfTotals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(short id, [Bind("Id,CertificateName,IdUser")] TypesOfTotals typeOfTotal)
        {
            if (id != typeOfTotal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeOfTotal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeOfTotalExists(typeOfTotal.Id))
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
            ViewData["IdUser"] = new SelectList(_context.Users, "Id", "Id", typeOfTotal.IdUser);
            return View(typeOfTotal);
        }

        // GET: TypesOfTotals/Delete/5
        public async Task<IActionResult> Delete(short? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeOfTotal = await _context.TypesOfTotals
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeOfTotal == null)
            {
                return NotFound();
            }

            return View(typeOfTotal);
        }

        // POST: TypesOfTotals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(short id)
        {
            var typeOfTotal = await _context.TypesOfTotals.FindAsync(id);
            _context.TypesOfTotals.Remove(typeOfTotal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeOfTotalExists(short id)
        {
            return _context.TypesOfTotals.Any(e => e.Id == id);
        }
    }
}