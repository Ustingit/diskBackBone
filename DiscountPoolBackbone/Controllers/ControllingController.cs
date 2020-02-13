using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiscountPoolBackbone.Models;

namespace DiscountPoolBackbone.Controllers
{
    public class ControllingController : Controller
    {
        private readonly DiscountsContext _context;

        public ControllingController(DiscountsContext context)
        {
            _context = context;
        }

        // GET: Controlling
        public async Task<IActionResult> Index()
        {
            var x = await _context.Clients.ToListAsync();

            return View(await _context.Clients?.Where(x => x.IsActive == true)?.ToListAsync() ?? new List<Client>());
        }

        // GET: Controlling/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Controlling/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Controlling/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,FatherName,Phone,Address,PassportAddresss,DateOfBirth,DocumentNumber,DocumentFrom,DocumentTo,Note,Language,Sex,IsActive")] Client client)
        {
            if (ModelState.IsValid)
            {
                client.CreatedDate = DateTime.Now;
                client.DepartmentId = 1; // finally there should be "Dep.Current" for Employee
                client.TotalPurchases = 0;
                client.Discount = 0;
                client.IsVip = false;
                client.IsActive = true;

                var t = client;
                //на данный момент тренера нет, а вот уже при заказе первом он может появится

                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Controlling/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Controlling/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,FatherName,Phone,Address,PassportAddresss,DateOfBirth,CreatedDate,Discount,TotalPurchases,DepartmentId,DocumentNumber,DocumentFrom,DocumentTo,IsVip,ConfigurationId,Note,Language,Sex,IsActive,LastVisit,CurrentCoachId,CoachNote")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.Id))
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
            return View(client);
        }

        // GET: Controlling/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Controlling/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}
