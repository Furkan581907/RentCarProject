using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCar.Data.Domain
{
    [Table("Company")]
    public class Company:BaseEntity,IAuditEntity
    {
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int CarCount { get; set; }

        //IAuditEntity Implementation
        public int CreateUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }


        public List<Company> Companys { get; set; }
        public List<Car> Cars { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
