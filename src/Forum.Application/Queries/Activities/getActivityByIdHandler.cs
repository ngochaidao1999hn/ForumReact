using Forum.Application.Models;
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
    public class getActivityByIdHandler : IRequestHandler<getActivityById, Result<Activity>>
    {
        private readonly IUnitOfWork _unitofwork;
        #region ctor
        public getActivityByIdHandler(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        #endregion
        public async Task<Result<Activity>> Handle(getActivityById request, CancellationToken cancellationToken)
        {
            Result<Activity> result = new Result<Activity>();
            result.CreateSuccessResult(await _unitofwork.ActivityRepository.GetById(request.Id));
            return result;
        }
    }
}
