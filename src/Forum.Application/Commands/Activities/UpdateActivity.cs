using Forum.Application.DTOs.Activity;
using Forum.Application.Models;
using Forum.Domain.Entities;
using MediatR;

namespace Forum.Application.Commands.Activities
{
    public class UpdateActivity : IRequest<Result<Activity>>
    {
        public ActivityDTO activity;

        #region ctor

        public UpdateActivity(ActivityDTO activity)
        {
            this.activity = activity;
        }

        #endregion ctor
    }
}