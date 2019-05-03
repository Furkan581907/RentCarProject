using RentCar.Data.Repo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity:BaseEntity
    {
        private RacContext _context = new RacContext();
        public GenericRepository(RacContext context)
        {
            _context = context;
            
        }
        public RacContext Context
        {
            get { return _context; }
            set { _context = value; }
        }
        public virtual void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public virtual IList<TEntity> GetAll()
        {
            var list = _context.Set<TEntity>().ToList();
            return list;
        }

        public virtual IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            var result = _context.Set<TEntity>().Where(predicate);
            return result.ToList();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            var result = _context.Set<TEntity>().Add(entity);
            return result;
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

       
    }
}
