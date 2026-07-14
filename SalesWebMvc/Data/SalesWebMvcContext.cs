using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SwmDepartment> SwmDepartment { get; set; }
        public DbSet<SwmSeller> SwmSeller { get; set; }
        public DbSet<SwmSalesRecord> SwmSalesRecord { get; set; }
    }
}
