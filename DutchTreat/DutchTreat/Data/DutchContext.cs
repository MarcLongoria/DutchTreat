using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchContext : DbContext 
    {
        public DutchContext(DbContextOptions<DutchContext> options) : base(options)
        {

        }


        DbSet<Product> Product { get; set; }
        DbSet<Order> Orders { get; set; }
    }
}
