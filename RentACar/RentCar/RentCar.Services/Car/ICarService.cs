using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data.Domain;

namespace RentCar.Services.Car
{
    public interface ICarService
    {

        List<RentCar.Data.Domain.Car> GetHomePageCar();
        
    }
}
