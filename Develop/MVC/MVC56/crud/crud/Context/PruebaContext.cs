using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace crud.Context
{
    public class PruebaContext:DbContext
    {
          public DbSet<Models.Customer> Customers { get; set; }
     
    }
}