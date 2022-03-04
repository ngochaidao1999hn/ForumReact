using Forum.Application.DTOs.Activity;
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
    public class UpdateActivity :IRequest<Result<Activity>>
    {
        public ActivityDTO activity;
        #region ctor
        public UpdateActivity(ActivityDTO activity)
        {
            this.activity = activity;
        }
        #endregion
    }
}
