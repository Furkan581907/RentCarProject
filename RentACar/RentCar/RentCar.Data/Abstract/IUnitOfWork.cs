using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get;  }
        ICompanyRepository Companies { get; }
        ICustomerRepository Customers { get; }
        IForRentRepository ForRents { get; }
        IWorkerRepository Workers { get;}

        int SaveChanges();
    }
}
