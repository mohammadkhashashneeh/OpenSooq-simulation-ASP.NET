using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpenSooq.Data;
using OpenSooq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSooq.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;

        }

        [HttpGet]

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var categories = from s in db.Categories select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                categories = categories.Where(s => s.CategoryName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    categories = categories.OrderByDescending(s => s.CategoryName);
                    break;
                case "Date":
                    categories = categories.OrderBy(s => s.CreationDate);
                    break;
                case "date_desc":
                    categories = categories.OrderByDescending(s => s.CreationDate);
                    break;
                default:
                    categories = categories.OrderBy(s => s.CategoryName);
                    break;
            }

            int pageSize = 4;
            return View(await PaginatedList<Category>.CreateAsync(categories.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        public IActionResult Product(int? id)
        {

            var data = db.Products.Where(x => x.CategoryId == id).OrderByDescending(x => x.CreationDate);
            return View(data);
        }

        public IActionResult ProductsShop(int? id)
        {

            var data = db.ProductShops.Where(x => x.ShopId == id).OrderByDescending(x => x.CreationDate);
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Shop(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var shops = from s in db.Shops select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                shops = shops.Where(s => s.ShopName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    shops = shops.OrderByDescending(s => s.ShopName);
                    break;
                case "Date":
                    shops = shops.OrderBy(s => s.CreationDate);
                    break;
                case "date_desc":
                    shops = shops.OrderByDescending(s => s.CreationDate);
                    break;
                default:
                    shops = shops.OrderBy(s => s.ShopName);
                    break;
            }

            int pageSize = 4;
            return View(await PaginatedList<Shop>.CreateAsync(shops.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> ShopDetails(int?id)
        {

            if (id == null)
            {
                return RedirectToAction("Shop");

            }
            var name = await db.Shops.Include(c => c.Category).Include(u=>u.User).FirstOrDefaultAsync(m => m.ShopId == id); 
            var data = db.Shops.Find(id);
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> ProductDetails(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Product");

            }
            var name = await db.Products.Include(c => c.Category).Include(u => u.User).FirstOrDefaultAsync(m => m.ProductId == id);
            var data = db.Products.Find(id);
            return View(data);
        }

        public async Task<IActionResult> ProductShopDetails(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Product");

            }
            var name = await db.ProductShops.Include(s=>s.Shop).Include(c => c.Shop.Category).Include(u => u.Shop.User).FirstOrDefaultAsync(m => m.ProductShopId == id);
            var data = db.ProductShops.Find(id);
            return View(data);
        }
        

        
    }
}
