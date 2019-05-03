using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Domain
{
    [Table("ForRent")]
    public class ForRent:BaseEntity,IAuditEntity
    {
        public int FisrtKm { get; set; }
        public int LastKm { get; set; }
        public int ReceivedFee { get; set; }//alınan ücreti anlamında 
        public DateTime RezDate { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }
        public int CarId { get; set; }

        //IAuditEntity Implementation
        public int CreateUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
