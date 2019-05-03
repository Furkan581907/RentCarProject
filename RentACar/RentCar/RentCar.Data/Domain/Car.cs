using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Domain
{
    [Table("Car")]

    public class Car:BaseEntity,IAuditEntity
    {

        public string CarName { get; set; }
        public string CarModel { get; set; }
        public int Price { get; set; }
        public bool isRent { get; set; }
        public bool ShowOnHomePage { get; set; }

        //IAuditEntity Implementation
        public int CreateUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public int? CompanyId { get; set; }

        [ForeignKey("WorkerId")]
        public Worker Worker { get; set; }
        public int? WorkerId { get; set; }



    }
}
