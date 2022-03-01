using AutoMapper;
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
    public class UpdateActivityHandler : IRequestHandler<UpdateActivity>
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
        public async Task<Unit> Handle(UpdateActivity request, CancellationToken cancellationToken)
        {
            var activity = await _unitofwork.ActivityRepository.GetById(request.activity.Id);
            _mapper.Map(request.activity, activity);
            _unitofwork.ActivityRepository.Update(activity);
            await _unitofwork.SaveChange();
            return Unit.Value;
        }
    }
}
