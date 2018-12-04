using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace linq.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Models.Product> Products { get; set; }
    }
}