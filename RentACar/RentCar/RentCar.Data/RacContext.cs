using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Domain;

namespace RentCar.Data
{
    public class RacContext:DbContext
    {
        public RacContext():base("racdeneme")
        {
            Database.SetInitializer<RacContext>(new DropCreateDatabaseIfModelChanges<RacContext>());
        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Worker> Worker { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<ForRent> forRent { get; set; }
    }
}
