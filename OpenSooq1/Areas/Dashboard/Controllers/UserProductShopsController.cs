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
    public class UserProductShopsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;

        public UserProductShopsController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Dashboard/UserProductShops
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.ProductShops.Include(p => p.Shop).Where(p => p.Shop.UserId == HttpContext.Session.GetInt32("UserId"));

            return View(await appDbContext.ToListAsync());
        }

        


        // GET: Dashboard/ProductShops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productShop = await _context.ProductShops
                .Include(p => p.Shop)
                .FirstOrDefaultAsync(m => m.ProductShopId == id);
            if (productShop == null)
            {
                return NotFound();
            }

            return View(productShop);
        }

        // GET: Dashboard/ProductShops/Create
        public IActionResult Create()
        {
            ViewData["ShopId"] = new SelectList(_context.Shops.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "ShopId", "ShopName");
            return View();
        }

        // POST: Dashboard/ProductShops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductShopId,ProductName,ProductDesc,ImageFile,ProductImg,Price,ShopId,CreationDate,IsDeleted,IsActive")] ProductShop productShop)
        {
            if (ModelState.IsValid)
            {
                if (productShop.ImageFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" +
                    productShop.ImageFile.FileName;
                    string path = Path.Combine(wwwRootPath + @"\newImg\", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await productShop.ImageFile.CopyToAsync(fileStream);
                    }
                    productShop.ProductImg = fileName;
                    _context.Add(productShop);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                _context.Add(productShop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShopId"] = new SelectList(_context.Shops.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "ShopId", "ShopName", productShop.ShopId);
            return View(productShop);
        }

        // GET: Dashboard/ProductShops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productShop = await _context.ProductShops.FindAsync(id);
            if (productShop == null)
            {
                return NotFound();
            }
            ViewData["ShopId"] = new SelectList(_context.Shops.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "ShopId", "ShopName", productShop.ShopId);
            return View(productShop);
        }

        // POST: Dashboard/ProductShops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductShopId,ProductName,ProductDesc,ImageFile,ProductImg,Price,ShopId,CreationDate,IsDeleted,IsActive")] ProductShop productShop)
        {
            if (id != productShop.ProductShopId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (productShop.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + "_" +
                        productShop.ImageFile.FileName;
                        string path = Path.Combine(wwwRootPath + @"\newImg\", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await productShop.ImageFile.CopyToAsync(fileStream);
                        }
                        productShop.ProductImg = fileName;
                    }
                    _context.Update(productShop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductShopExists(productShop.ProductShopId))
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
            ViewData["ShopId"] = new SelectList(_context.Shops.Where(p => p.UserId == HttpContext.Session.GetInt32("UserId")), "ShopId", "ShopName", productShop.ShopId);
            return View(productShop);
        }

        // GET: Dashboard/ProductShops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productShop = await _context.ProductShops
                .Include(p => p.Shop)
                .FirstOrDefaultAsync(m => m.ProductShopId == id);
            if (productShop == null)
            {
                return NotFound();
            }

            return View(productShop);
        }

        // POST: Dashboard/ProductShops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productShop = await _context.ProductShops.FindAsync(id);
            _context.ProductShops.Remove(productShop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductShopExists(int id)
        {
            return _context.ProductShops.Any(e => e.ProductShopId == id);
        }
    }
}
