using Forum.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Commands.Activities
{
    public class DeleteActivity:IRequest
    {
        public Guid Id;
        #region ctor
        public DeleteActivity(Guid Id)
        {
            this.Id = Id;
        }
        #endregion
    }
}
