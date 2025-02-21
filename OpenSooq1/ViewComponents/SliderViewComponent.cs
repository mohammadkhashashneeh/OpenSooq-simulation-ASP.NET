using OpenSooq.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace OpenSooq.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private AppDbContext db;

        public SliderViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Sliders.OrderByDescending(x => x.CreationDate);
            return View(data);
        }
    }
}