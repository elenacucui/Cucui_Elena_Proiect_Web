using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cucui_Elena_Proiect_Web.Models;

namespace Cucui_Elena_Proiect_Web.Data
{
    public class Cucui_Elena_Proiect_WebContext : DbContext
    {
        public Cucui_Elena_Proiect_WebContext (DbContextOptions<Cucui_Elena_Proiect_WebContext> options)
            : base(options)
        {
        }

        public DbSet<Cucui_Elena_Proiect_Web.Models.Product> Product { get; set; }

        public DbSet<Cucui_Elena_Proiect_Web.Models.Category> Category { get; set; }

        public DbSet<Cucui_Elena_Proiect_Web.Models.Client> Client { get; set; }

        public DbSet<Cucui_Elena_Proiect_Web.Models.Order> Order { get; set; }

        public DbSet<Cucui_Elena_Proiect_Web.Models.OrderLine> OrderLine { get; set; }

        public DbSet<Cucui_Elena_Proiect_Web.Models.ProductCategory> ProductCategory { get; set; }


    }
}
