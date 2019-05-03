using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentCar.Data;
using RentCar.Data.Domain;
using RentCar.Services.Car;
using RentCar.Services.Companies;

namespace RentCar.Web.Controllers
{
    public class HomeController : Controller
    {
        private GenericUnitOfWork unitOfWork = null;
        public HomeController()
        {
            unitOfWork = new GenericUnitOfWork();
        }
        // GET: Home
        public ActionResult Index()
        {
            //var Cars = new Car
            //{
            //    CarName = "audi",
            //    CarModel = "a3",
            //    Price = 555,
            //    isRent = true,
            //    ShowOnHomePage = true,
            //    CompanyId = 5,
            //    WorkerId = 2,
            //    CreateUserId = 2,
            //    CreatedDate = DateTime.Now,
            //    UpdatedUserId = 2,
            //    UpdatedDate = DateTime.Now
            //};
            //unitOfWork.Repository<Car>().Insert(Cars);
            //unitOfWork.SaveChanges();
           
           
            var model = new List<Car>();
            model = unitOfWork.Repository<Car>().GetAll().ToList();
                return View(model);
        }
    }
}