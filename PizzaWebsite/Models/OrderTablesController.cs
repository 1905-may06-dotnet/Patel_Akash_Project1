using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pizzaboxdata.Data;

namespace PizzaWebsite.Models
{
    public class OrderTablesController : Controller
    {
        private readonly PizzaContext _context;

        public OrderTablesController(PizzaContext context)
        {
            _context = context;
        }

        // GET: OrderTables
        public async Task<IActionResult> Index()
        {
            var pizzaContext = _context.OrderTable.Include(o => o.LocationFkNavigation).Include(o => o.UsernameFkNavigation);
            return View(await pizzaContext.ToListAsync());
        }

        // GET: OrderTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderTable = await _context.OrderTable
                .Include(o => o.LocationFkNavigation)
                .Include(o => o.UsernameFkNavigation)
                .FirstOrDefaultAsync(m => m.OrderIdPk == id);
            if (orderTable == null)
            {
                return NotFound();
            }

            return View(orderTable);
        }

        // GET: OrderTables/Create
        public IActionResult Create()
        {
            ViewData["LocationFk"] = new SelectList(_context.LocationTable, "LocationPk", "LocationPk");
            ViewData["UsernameFk"] = new SelectList(_context.UserTable, "UsernamePk", "UsernamePk");
            return View();
        }

        // POST: OrderTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderIdPk,UsernameFk,OrderTotalCost,OrderDateTime,LocationFk")] OrderTable orderTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationFk"] = new SelectList(_context.LocationTable, "LocationPk", "LocationPk", orderTable.LocationFk);
            ViewData["UsernameFk"] = new SelectList(_context.UserTable, "UsernamePk", "UsernamePk", orderTable.UsernameFk);
            return View(orderTable);
        }

        // GET: OrderTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderTable = await _context.OrderTable.FindAsync(id);
            if (orderTable == null)
            {
                return NotFound();
            }
            ViewData["LocationFk"] = new SelectList(_context.LocationTable, "LocationPk", "LocationPk", orderTable.LocationFk);
            ViewData["UsernameFk"] = new SelectList(_context.UserTable, "UsernamePk", "UsernamePk", orderTable.UsernameFk);
            return View(orderTable);
        }

        // POST: OrderTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderIdPk,UsernameFk,OrderTotalCost,OrderDateTime,LocationFk")] OrderTable orderTable)
        {
            if (id != orderTable.OrderIdPk)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderTableExists(orderTable.OrderIdPk))
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
            ViewData["LocationFk"] = new SelectList(_context.LocationTable, "LocationPk", "LocationPk", orderTable.LocationFk);
            ViewData["UsernameFk"] = new SelectList(_context.UserTable, "UsernamePk", "UsernamePk", orderTable.UsernameFk);
            return View(orderTable);
        }

        // GET: OrderTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderTable = await _context.OrderTable
                .Include(o => o.LocationFkNavigation)
                .Include(o => o.UsernameFkNavigation)
                .FirstOrDefaultAsync(m => m.OrderIdPk == id);
            if (orderTable == null)
            {
                return NotFound();
            }

            return View(orderTable);
        }

        // POST: OrderTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderTable = await _context.OrderTable.FindAsync(id);
            _context.OrderTable.Remove(orderTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderTableExists(int id)
        {
            return _context.OrderTable.Any(e => e.OrderIdPk == id);
        }
    }
}
