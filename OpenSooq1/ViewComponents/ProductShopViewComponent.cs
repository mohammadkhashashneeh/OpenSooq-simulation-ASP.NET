using OpenSooq.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace OpenSooq.ViewComponents
{
    public class ProductShopViewComponent : ViewComponent
    {
        private AppDbContext db;

        public ProductShopViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.ProductShops.OrderByDescending(x => x.CreationDate);
            return View(data);
        }
    }
}