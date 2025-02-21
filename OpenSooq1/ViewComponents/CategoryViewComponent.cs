using OpenSooq.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace OpenSooq.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        private AppDbContext db;

        public CategoryViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Categories.OrderByDescending(x => x.CreationDate);
            return View(data);
        }
    }
}