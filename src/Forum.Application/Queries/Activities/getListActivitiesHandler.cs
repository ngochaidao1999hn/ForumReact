using Forum.Application.Models;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Forum.Application.Queries.Activities
{
    public class getListActivitiesHandler : IRequestHandler<getListActivities, Result<List<Activity>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        #region ctor

        public getListActivitiesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion ctor

        public async Task<Result<List<Activity>>> Handle(getListActivities request, CancellationToken cancellationToken)
        {
            Result<List<Activity>> result = new Result<List<Activity>>();
            result.CreateSuccessResult(await _unitOfWork.ActivityRepository.GetAll());
            return result;
        }
    }
}