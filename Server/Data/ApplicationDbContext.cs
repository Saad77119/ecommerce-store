using Estore.Server.Models;
using Estore.Shared.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Estore.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

       
        

    }
    public class DataContext : DbContext
    {
       
            public virtual DbSet<ProductCatagory> ProductCatagorys { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Catagory> Catagorys { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
       


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                _ = optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=eccomerence_store;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
       
    }

}
