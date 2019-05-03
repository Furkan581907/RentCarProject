using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Domain
{
    [Table("Customer")]
    public class Customer:BaseEntity,IAuditEntity
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Usernam { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //IAuditEntity Implementation
        public int CreateUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
    }
}
