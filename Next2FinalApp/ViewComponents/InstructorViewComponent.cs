using IdentityCoreNext2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.ViewComponents
{
    public class InstructorViewComponent : ViewComponent
    {
        private AppDbContext db;

        public InstructorViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Instructors.OrderByDescending(x => x.CreationDate).Take(6);
            return View(data);
        }
    }
}