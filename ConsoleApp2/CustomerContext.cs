using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp2
{
    class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
