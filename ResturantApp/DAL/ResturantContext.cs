using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResturantApp.Models;
using System.Data.Entity;
namespace ResturantApp.DAL
{
    public class ResturantContext : DbContext
    {

        public DbSet<Category> Categories { set; get; }
        public DbSet<Item> Items { set; get; }

        public ResturantContext() : base("DefaultConnection") 
        { }



    }
}