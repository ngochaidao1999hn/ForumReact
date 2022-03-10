using Forum.Application.Models;
using Forum.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Forum.Application.Commands.Activities
{
    public class DeleteActivityHandler : IRequestHandler<DeleteActivity, Result<Guid>>
    {
        private IUnitOfWork _unitofwork;

        #region ctor

        public DeleteActivityHandler(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        #endregion ctor

        public async Task<Result<Guid>> Handle(DeleteActivity request, CancellationToken cancellationToken)
        {
            Result<Guid> result = new Result<Guid>();
            List<string> messages = new List<string>();
            try
            {
                var entityToDelete = await _unitofwork.ActivityRepository.GetById(request.Id);
                _unitofwork.ActivityRepository.Delete(entityToDelete);
                await _unitofwork.SaveChange();
                result.CreateSuccessResult(request.Id);
                messages.Add("Delete Activity with Id: " + request.Id + " Successful");
                result.Messages = messages;
            }
            catch (Exception e)
            {
                messages.Add(e.InnerException.ToString());
                result.CreateFailureResult(messages);
            }

            return result;
        }
    }
}