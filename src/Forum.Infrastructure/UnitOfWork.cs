using Forum.Domain;
using Forum.Domain.Entities;
using Forum.Domain.Repositories.Base;
using Forum.Infrastructure.Repositories.Base;
using System;
using System.Threading.Tasks;

namespace Forum.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ForumDbContext _context;
        private bool disposedValue;

        #region ctor

        public UnitOfWork(ForumDbContext context)
        {
            _context = context;
        }

        #endregion ctor

        #region repositories

        IRepository<Activity> IUnitOfWork.ActivityRepository => new Repository<Activity>(_context);

        #endregion repositories

        #region methods

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion methods
    }
}