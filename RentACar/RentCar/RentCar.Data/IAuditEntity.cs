using System;

namespace RentCar.Data
{
    public interface IAuditEntity
    {
        int CreateUserId { get; set; }
        DateTime CreatedDate { get; set; }
        int UpdatedUserId { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}
