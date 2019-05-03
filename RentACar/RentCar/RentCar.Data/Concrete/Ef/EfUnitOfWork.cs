using RentCar.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Concrete.Ef
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private Context context;

        public EfUnitOfWork(Context _context)
        {
            context = _context ?? throw new ArgumentNullException("Db Context can not be null");
        }

        public ICarRepository _cars;
        public ICompanyRepository _companies;
        public ICustomerRepository _customers;
        public IForRentRepository _forRents;
        public IWorkerRepository _workers;
        public ICarRepository Cars
        {
            get
            {
                return _cars ?? (_cars = new EfCarRepository(context));
            }
        }
        public ICompanyRepository Companies
        {
            get
            {
                return _companies ?? (_companies = new EfCompanyRepository(context));
            }
        }
        public ICustomerRepository Customers
        {
            get
            {
                return _customers ?? (_customers = new EfCustomerRepository(context));
            }
        }
        public IForRentRepository ForRents
        {
            get
            {
                return _forRents ?? (_forRents = new EfForRentRepository(context));
            }
        }
        public IWorkerRepository Workers
        {
            get
            {
                return _workers ?? (_workers = new EfWorkerRepository(context));
            }
        }

   
        public void Dispose()
        {
            context.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

