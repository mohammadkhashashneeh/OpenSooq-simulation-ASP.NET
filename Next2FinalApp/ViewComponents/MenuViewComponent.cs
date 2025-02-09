using IdentityCoreNext2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private AppDbContext db;

        public MenuViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Menus ;
            return View(data);
        }
    }
}