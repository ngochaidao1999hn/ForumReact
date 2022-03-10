using Forum.Application.Models;
using Forum.Domain.Entities;
using MediatR;

namespace Forum.Application.Commands.Activities
{
    public class CreateActivity : IRequest<Result<Activity>>
    {
        public Activity activity;

        #region ctor

        public CreateActivity(Activity activity)
        {
            this.activity = activity;
        }

        #endregion ctor
    }
}