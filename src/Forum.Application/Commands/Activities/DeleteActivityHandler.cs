using Forum.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forum.Application.Commands.Activities
{
    public class DeleteActivityHandler : IRequestHandler<DeleteActivity>
    {
        private IUnitOfWork _unitofwork;
        #region ctor
        public DeleteActivityHandler(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        #endregion
        public async Task<Unit> Handle(DeleteActivity request, CancellationToken cancellationToken)
        {
            var entityToDelete = await _unitofwork.ActivityRepository.GetById(request.Id);
            _unitofwork.ActivityRepository.Delete(entityToDelete);
            await _unitofwork.SaveChange();
            return Unit.Value;
        }
    }
}
