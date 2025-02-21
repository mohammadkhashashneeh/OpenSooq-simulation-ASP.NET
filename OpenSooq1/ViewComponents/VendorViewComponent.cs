using OpenSooq.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace OpenSooq.ViewComponents
{
    public class VendorViewComponent : ViewComponent
    {
        private AppDbContext db;

        public VendorViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Vendors.OrderByDescending(x => x.CreationDate);
            return View(data);
        }
    }
}