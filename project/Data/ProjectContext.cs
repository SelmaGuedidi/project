using Magasin.Models;
using Microsoft.EntityFrameworkCore;

using System.Diagnostics;

namespace Magasin.Data
{
    public class ProjectContext : DbContext

    {
        public DbSet<User> User { get; set; }
       
        public DbSet<Category> Category { get; set; }
       
        public DbSet<Product> Product { get; set; }
        public DbSet<Stock> Stock { get; set; }
        
        public DbSet<Vendor> Vendor { get; set; }
        
        private ProjectContext(DbContextOptions o) : base(o)
        {
        }

       private static ProjectContext? Context;
        public static ProjectContext Instance()
        {

           // if (Context == null)
           // {
                var optionsBuilder = new DbContextOptionsBuilder<ProjectContext>();
                optionsBuilder.UseSqlite("Data Source=\\Users\\selma\\DB\\Project.db");
                Debug.WriteLine("Une nouvelle instance créee!");
                Context = new ProjectContext(optionsBuilder.Options);
            //}

            return Context;

        }


    }
}