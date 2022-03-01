using Forum.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain.Repositories.Base
{
    public interface IRepository<T> where T:EntityBase
    {
        Task<List<T>> GetAll();
        Task<List<T>> Get(Expression<Func<T, bool>> filter = null,Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        Task<T> GetById(Guid Id);
        void Add(T entity);
        Task Delete(T entity);
        void Update(T entity);
    }
}
