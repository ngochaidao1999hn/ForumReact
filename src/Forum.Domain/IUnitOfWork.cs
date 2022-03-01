using Forum.Domain.Entities;
using Forum.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Activity> ActivityRepository { get; }
        Task SaveChange();
    }
}
