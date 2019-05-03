
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentCar.Data.Concrete.Ef
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ForRent> ForRents { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}

