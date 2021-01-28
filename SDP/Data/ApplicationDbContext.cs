using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SDP.Models;

namespace SDP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<product> products { get; set; }
        //public DbSet<ProductViewModel> productsViewModel { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<staff> staffs { get; set; }
        public DbSet<Order> order { get; set; }


    }
}
