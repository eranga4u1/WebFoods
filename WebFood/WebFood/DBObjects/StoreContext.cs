using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebFood.Models;

namespace WebFood.DBObjects
{
    public partial class StoreContext : DbContext
    {
        public StoreContext():base("name=StoreContext") { }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }////
    }
}