using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using RentCar.Data;
using RentCar.Data.Domain;

namespace RentCarWebService
{
    /// <summary>
    /// Summary description for AddCompany
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddCompany : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        private GenericUnitOfWork unitOfWork = null;

        [WebMethod]
        public bool AddCompanys(string sirketadi, string sehir, string adres, string aracsayisi)
        {
            try
            {
                unitOfWork = new GenericUnitOfWork(); var company = new Company
                {
                    CompanyName = sirketadi,
                    Address = sehir,
                    City = adres,
                    CarCount = 0,
                    CreatedDate = DateTime.Now,
                    CreateUserId = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedUserId = 1
                };
                unitOfWork.Repository<Company>().Insert(company);
                unitOfWork.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public bool AddWorker(string workername, string surname, string address,string number, string email,string password)
        {
            try
            {
                unitOfWork = new GenericUnitOfWork();
                var worker = new Worker
                {
                    WorkerName = workername,
                    WorkerSurname = surname,
                    Address = address,
                    Number = int.Parse(number),
                    CompanyID = 1,
                    email = email,
                    Password = password,
                    CreatedDate = DateTime.Now,
                    CreateUserId = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedUserId = 1
                };
                unitOfWork.Repository<Worker>().Insert(worker);
                unitOfWork.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public bool AddForRent(string carId, string FirstKm, string LastKm, string CustomerId, string ReceivedFee, string RezDate)
        {
            try
            {
                unitOfWork = new GenericUnitOfWork();
                var forrentt = new ForRent
                {
                    CarId = int.Parse(carId),
                    FisrtKm = int.Parse(FirstKm),
                    LastKm = int.Parse(LastKm),
                    CustomerId = int.Parse(CustomerId),
                    ReceivedFee = int.Parse(ReceivedFee),
                    RezDate = DateTime.Parse(RezDate),
                    CreatedDate = DateTime.Now,
                    CreateUserId = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedUserId = 1
                };
                unitOfWork.Repository<ForRent>().Insert(forrentt);
                unitOfWork.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
        [WebMethod]
        public bool AddCar(string carmodel, string carname, string companyID, string workerID, bool isrent, bool showonmypage,string Price)
        {
            try
            {
                unitOfWork = new GenericUnitOfWork();
                var car = new Car
                {
                    CarModel = carmodel,
                    CarName = carname,
                    CompanyId = int.Parse(companyID),
                    WorkerId = int.Parse(workerID),
                    isRent = isrent,
                    ShowOnHomePage = showonmypage,
                    Price = int.Parse(Price),
                    CreatedDate = DateTime.Now,
                    CreateUserId = 1,
                    UpdatedDate = DateTime.Now,
                    UpdatedUserId = 1
                };
                unitOfWork.Repository<Car>().Insert(car);
                unitOfWork.SaveChanges();

                return true;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
