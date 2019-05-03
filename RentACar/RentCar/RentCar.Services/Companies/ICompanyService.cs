using RentCar.Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Services.Companies
{
    public interface ICompanyService
    {
        IList<Company> GetAll();
        Company GetById(int Id);
        Company Insertcompany(Company company);
        Company Updatecompany(Company company);
        bool Deletecompany(Company company);
    }
}
