using OpenSooq.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace OpenSooq.ViewComponents
{
    public class ShopViewComponent : ViewComponent
    {
        private AppDbContext db;

        public ShopViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Shops.OrderByDescending(x => x.CreationDate);
            return View(data);
        }
    }
}