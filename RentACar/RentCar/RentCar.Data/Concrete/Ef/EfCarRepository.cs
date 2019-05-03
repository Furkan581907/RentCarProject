using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Concrete.Ef
{
    public class EfCarRepository : EfGenericRepository<Car>, ICarRepository
    {
        public EfCarRepository(Context context) : base(context)
        {

        }
        public Context RContext
        {
            get { return context as Context; }
        }

        
    }
}
