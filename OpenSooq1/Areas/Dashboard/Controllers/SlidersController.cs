using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OpenSooq.Data;
using OpenSooq.Models;
using OpenSooq.Models.ViewModel;

namespace OpenSooq.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _hostEnvironment;
        public SlidersController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }


        // GET: Dashboard/Sliders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sliders.ToListAsync());
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

            var sliders = from s in _context.Sliders select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                sliders = sliders.Where(s => s.SliderTitle.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    sliders = sliders.OrderByDescending(s => s.SliderTitle);
                    break;
                case "Date":
                    sliders = sliders.OrderBy(s => s.CreationDate);
                    break;
                case "date_desc":
                    sliders = sliders.OrderByDescending(s => s.CreationDate);
                    break;
                default:
                    sliders = sliders.OrderBy(s => s.SliderTitle);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<Slider>.CreateAsync(sliders.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Dashboard/Sliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.SliderId == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // GET: Dashboard/Sliders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Sliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SliderId,SliderTitle,SliderSubTitle,OfferPrice,ImageFile,Price,Currency,BtnTxt,BtnUrl,SliderImg,CreationDate,IsDeleted,IsActive")] Slider slider)
        {
            if (ModelState.IsValid)
            {
                if (slider.ImageFile != null)
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string fileName = Guid.NewGuid().ToString() + "_" +
                    slider.ImageFile.FileName;
                    string path = Path.Combine(wwwRootPath + @"\newImg\", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await slider.ImageFile.CopyToAsync(fileStream);
                    }
                    slider.SliderImg = fileName;
                }
                _context.Add(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slider);
        }

        // GET: Dashboard/Sliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }

        // POST: Dashboard/Sliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SliderId,SliderTitle,SliderSubTitle,ImageFile,OfferPrice,Price,Currency,BtnTxt,BtnUrl,SliderImg,CreationDate,IsDeleted,IsActive")] Slider slider)
        {
            if (id != slider.SliderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (slider.ImageFile != null)
                    {
                        string wwwRootPath = _hostEnvironment.WebRootPath;
                        string fileName = Guid.NewGuid().ToString() + "_" +
                        slider.ImageFile.FileName;
                        string path = Path.Combine(wwwRootPath + @"\newImg\", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await slider.ImageFile.CopyToAsync(fileStream);
                        }
                        slider.SliderImg = fileName;
                    }
                    _context.Update(slider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliderExists(slider.SliderId))
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
            return View(slider);
        }

        // GET: Dashboard/Sliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.SliderId == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // POST: Dashboard/Sliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SliderExists(int id)
        {
            return _context.Sliders.Any(e => e.SliderId == id);
        }
    }
}
