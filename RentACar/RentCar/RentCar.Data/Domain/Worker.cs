using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Domain
{
    [Table("Worker")]

    public class Worker:BaseEntity,IAuditEntity
    {
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
        
        //IAuditEntity Implementation
        public int CreateUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }

        
        [ForeignKey("CompanyID")]
        public Company Company { get; set; }
        public int? CompanyID { get; set; }
    }
}
