using Forum.Domain.Entities;
using Forum.Domain.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly ForumDbContext _context;
        private  DbSet<T> dbSet;
        #region ctor
        public Repository(ForumDbContext context)
        {
            _context = context;
            this.dbSet = context.Set<T>();
        }
        #endregion
        #region methods
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
             dbSet.Remove(entity);
        }

        public async Task<List<T>> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetById(Guid Id)
        {
            return await dbSet.FindAsync(Id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
        #endregion
    }
}
