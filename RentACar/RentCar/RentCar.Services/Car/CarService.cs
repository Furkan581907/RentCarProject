using RentCar.Data;
using RentCar.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Services.Car
{
    public partial class CarService : ICarService
    {
        private GenericUnitOfWork _uow = null;
        public CarService()
        {
            _uow = new GenericUnitOfWork();
        }
        public List<Data.Domain.Car> GetHomePageCar()
        {
            var cars = _uow.Repository<RentCar.Data.Domain.Car>().Where(p => p.ShowOnHomePage).ToList();
            return cars;
        }
    }
}
