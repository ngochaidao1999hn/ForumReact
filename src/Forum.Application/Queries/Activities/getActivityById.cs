using Forum.Application.Models;
using Forum.Domain.Entities;
using MediatR;
using System;

namespace Forum.Application.Queries.Activities
{
    public class getActivityById : IRequest<Result<Activity>>
    {
        public Guid Id { get; set; }

        #region ctor

        public getActivityById(Guid Id)
        {
            this.Id = Id;
        }

        #endregion ctor
    }
}