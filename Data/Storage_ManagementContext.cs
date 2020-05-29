using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data
{
    public class Storage_ManagementContext :DbContext
    {
        public DbSet<Employee> Staff { get; set; }
        public DbSet<Depot> Depots { get; set; }
        public DbSet<Product> Products { get; set; }

        public Storage_ManagementContext():base("storage_management")
        {
                
        }

    }
}
