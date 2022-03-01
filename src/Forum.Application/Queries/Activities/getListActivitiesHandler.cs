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
    public class getListActivitiesHandler : IRequestHandler<getListActivities, List<Activity>>
    {
        private readonly IUnitOfWork _unitOfWork;
        #region ctor
        public getListActivitiesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion
        public async Task<List<Activity>> Handle(getListActivities request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.ActivityRepository.GetAll();
        }
    }
}
