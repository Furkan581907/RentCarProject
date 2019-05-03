﻿using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Concrete.Ef
{
    public class EfForRentRepository:EfGenericRepository<ForRent>, IForRentRepository
    {
        public EfForRentRepository(Context context) : base(context)
        {

        }
        public Context RContext
        {
            get { return context as Context; }
        }
    }
}