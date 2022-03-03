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
    public class CreateActivityHandler : IRequestHandler<CreateActivity, Result<Activity>>
    {
        private IUnitOfWork _unitofwork;
        #region ctor
        public CreateActivityHandler(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        #endregion
        public async Task<Result<Activity>> Handle(CreateActivity request, CancellationToken cancellationToken)
        {
            Result<Activity> result = new Result<Activity>();
            List<string> messages = new List<string>();
            try
            {
                _unitofwork.ActivityRepository.Add(request.activity);
                await _unitofwork.SaveChange();
                result.CreateSuccessResult(request.activity);
                messages.Add("Create New Activity Successful");
                result.Messages = messages;               
            }
            catch(Exception e){
                messages.Add(e.InnerException.ToString());
                result.CreateFailureResult(messages);             
            }
            return result;
        }
    }
}
