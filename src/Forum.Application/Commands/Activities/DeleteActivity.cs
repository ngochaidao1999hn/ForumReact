using Forum.Application.Models;
using MediatR;
using System;

namespace Forum.Application.Commands.Activities
{
    public class DeleteActivity : IRequest<Result<Guid>>
    {
        public Guid Id;

        #region ctor

        public DeleteActivity(Guid Id)
        {
            this.Id = Id;
        }

        #endregion ctor
    }
}