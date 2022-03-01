using Forum.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Queries.Activities
{
    public class getActivityById :IRequest<Activity>
    {
        public Guid Id { get; set; }
        #region ctor
        public getActivityById(Guid Id)
        {
            this.Id = Id;
        }
        #endregion
    }
}
