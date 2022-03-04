using AutoMapper;
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

namespace Forum.Application.Commands.Activities
{
    public class UpdateActivityHandler : IRequestHandler<UpdateActivity,Result<Activity>>
    {
        private IUnitOfWork _unitofwork;
        private IMapper _mapper;
        #region ctor
        public UpdateActivityHandler(IUnitOfWork unitofwork,IMapper mapper)
        {
            _unitofwork = unitofwork;
            _mapper = mapper;
        }
        #endregion
        public async Task<Result<Activity>> Handle(UpdateActivity request, CancellationToken cancellationToken)
        {
            Result<Activity> result = new Result<Activity>();
            List<string> messages = new List<string>();
            try {
                var activity = await _unitofwork.ActivityRepository.GetById(request.activity.Id);
                _mapper.Map(request.activity, activity);
                activity.ModifiedOn = DateTime.Now;
                _unitofwork.ActivityRepository.Update(activity);
                await _unitofwork.SaveChange();
                result.CreateSuccessResult(activity);
                messages.Add("Update Activity Successful");
                result.Messages = messages;

            } catch (Exception e) {
                messages.Add(e.InnerException.ToString());
                result.CreateFailureResult(messages);
            }

            return result;
        }
    }
}
