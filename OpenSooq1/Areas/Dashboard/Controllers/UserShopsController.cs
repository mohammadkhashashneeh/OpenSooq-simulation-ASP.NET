using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpenSooq.Data;
using OpenSooq.Models;

namespace OpenSooq.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class UserShopsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;

        public UserShopsController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Dashboard/UserShops
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Shops.Include(s => s.Category).Include(s => s.User).Where(p => p.UserId == HttpContext.Session.GetInt32("UserId"));
            return View(await appDbContext.ToListAsync());
        }

        // GET: Dashboard/UserShops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .Include(s => s.Category)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ShopId == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // GET: Dashboard/UserShops/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["UserId"] = new SelectList(_context.Users.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "UserId", "UserName");
            return View();
        }

        // POST: Dashboard/Shops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShopId,ShopName,ShopDescription,ImageFile,ShopImage,ShopCity,CategoryId,UserId,CreationDate,IsDeleted,IsActive")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                if (shop.ImageFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" +
                    shop.ImageFile.FileName;
                    string path = Path.Combine(wwwRootPath + @"\newImg\", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await shop.ImageFile.CopyToAsync(fileStream);
                    }
                    shop.ShopImage = fileName;
                }

                _context.Add(shop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", shop.CategoryId);
            ViewData["UserId"] = new SelectList(_context.Users.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "UserId", "UserName", shop.UserId);
            return View(shop);
        }

        // GET: Dashboard/Shops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops.FindAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", shop.CategoryId);
            ViewData["UserId"] = new SelectList(_context.Users.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "UserId", "UserName", shop.UserId);
            return View(shop);
        }

        // POST: Dashboard/Shops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShopId,ShopName,ShopDescription,ImageFile,ShopImage,ShopCity,CategoryId,UserId,CreationDate,IsDeleted,IsActive")] Shop shop)
        {
            if (id != shop.ShopId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (shop.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + "_" +
                        shop.ImageFile.FileName;
                        string path = Path.Combine(wwwRootPath + @"\newImg\", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await shop.ImageFile.CopyToAsync(fileStream);
                        }
                        shop.ShopImage = fileName;
                    }
                    _context.Update(shop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShopExists(shop.ShopId))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", shop.CategoryId);
            ViewData["UserId"] = new SelectList(_context.Users.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "UserId", "UserName", shop.UserId);
            return View(shop);
        }

        // GET: Dashboard/UserShops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await _context.Shops
                .Include(s => s.Category)
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.ShopId == id);
            if (shop == null)
            {
                return NotFound();
            }

            return View(shop);
        }

        // POST: Dashboard/UserShops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shop = await _context.Shops.FindAsync(id);
            _context.Shops.Remove(shop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShopExists(int id)
        {
            return _context.Shops.Any(e => e.ShopId == id);
        }
    }
}
