using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Easy.Models
{
    public class CarDBContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}