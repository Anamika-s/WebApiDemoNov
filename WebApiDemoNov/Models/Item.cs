using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiDemoNov.Models
{
    public class Item
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public int qtyStock { get; set; }
        public string description { get; set; }
    }

    public class ItemDbContext : DbContext
    {
        public DbSet<Item> items { get; set; }
    }
}