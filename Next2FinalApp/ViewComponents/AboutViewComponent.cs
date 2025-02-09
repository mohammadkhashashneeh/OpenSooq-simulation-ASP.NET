using IdentityCoreNext2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private AppDbContext db;

        public AboutViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Abouts ;
            return View(data);
        }
    }
}