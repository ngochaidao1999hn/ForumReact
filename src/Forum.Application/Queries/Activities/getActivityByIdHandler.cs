using Forum.Application.Models;
using Forum.Domain;
using Forum.Domain.Entities;
using MediatR;
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

        #endregion ctor

        public async Task<Result<Activity>> Handle(getActivityById request, CancellationToken cancellationToken)
        {
            Result<Activity> result = new Result<Activity>();
            result.CreateSuccessResult(await _unitofwork.ActivityRepository.GetById(request.Id));
            return result;
        }
    }
}