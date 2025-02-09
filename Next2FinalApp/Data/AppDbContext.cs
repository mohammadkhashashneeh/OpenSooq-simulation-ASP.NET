using Microsoft.EntityFrameworkCore;
using Next2FinalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCoreNext2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }



    }
}
