using Forum.Application.Models;
using Forum.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Commands.Activities
{
    public class CreateActivity:IRequest<Result<Activity>>
    {
        public Activity activity;
        #region ctor
        public CreateActivity(Activity activity)
        {
            this.activity = activity;
        }
        #endregion
    }
}
