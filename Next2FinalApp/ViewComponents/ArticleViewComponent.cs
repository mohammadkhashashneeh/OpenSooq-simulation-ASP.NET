using IdentityCoreNext2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Next2FinalApp.ViewComponents
{
    public class ArticleViewComponent : ViewComponent
    {
        private AppDbContext db;

        public ArticleViewComponent(AppDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Articles.OrderByDescending(x => x.CreationDate).Take(3);
            return View(data);
        }
    }
}