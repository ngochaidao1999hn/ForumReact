using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forum.Application.Queries.Activities
{
    public class getActivityByIdHandler : IRequestHandler<getActivityById, Activity>
    {
        private readonly IUnitOfWork _unitofwork;
        #region ctor
        public getActivityByIdHandler(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        #endregion
        public async Task<Activity> Handle(getActivityById request, CancellationToken cancellationToken)
        {
            return await _unitofwork.ActivityRepository.GetById(request.Id);
        }
    }
}
