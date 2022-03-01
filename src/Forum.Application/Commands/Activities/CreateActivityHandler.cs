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
    public class CreateActivityHandler : IRequestHandler<CreateActivity>
    {
        private IUnitOfWork _unitofwork;
        #region ctor
        public CreateActivityHandler(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        #endregion
        public async Task<Unit> Handle(CreateActivity request, CancellationToken cancellationToken)
        {
            _unitofwork.ActivityRepository.Add(request.activity);
            await _unitofwork.SaveChange();
            return Unit.Value;
        }
    }
}
