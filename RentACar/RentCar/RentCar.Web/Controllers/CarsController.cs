using RentCar.Services.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentCar.Web.Controllers
{
    public class CarsController : Controller
    {
        CarService _carService = null;
        public CarsController()
        {
            _carService = new CarService();
        }
        // GET: Cars
        public ActionResult HomePageCars()
        {
            var model = _carService.GetHomePageCar();
            return View(model);
        }
    }
}