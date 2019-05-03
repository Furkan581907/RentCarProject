using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Repo
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();
        IList<TEntity> Where(Expression<Func<TEntity,bool>> predicate);
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
