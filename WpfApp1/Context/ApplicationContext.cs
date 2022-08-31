using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.Context
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Project> Projects { get; set; } = null!;

        public DbSet<Building> Buildings { get; set; } = null!;

        public DbSet<Complect> Complects { get; set; } = null!;

        public DbSet<Document> Documents { get; set; } = null!;

        public DbSet<Catalog> Catalogs { get; set; } = null!;
        public DbSet<Write> Writes { get; set; } = null!;


        public ApplicationContext()
        {
            Database.EnsureDeleted(); 
            Database.EnsureCreated();
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Projects.db");
        }
    }
}
