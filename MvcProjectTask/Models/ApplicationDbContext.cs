using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcProjectTask.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MyCon")
        {
           
        }

        public DbSet<FruitsAndVegetables> shop { get; set; }

     //   public DbSet<Category> categories { get; set; }
       // public DbSet<Pack> packs { get; set; }
        

    }
}