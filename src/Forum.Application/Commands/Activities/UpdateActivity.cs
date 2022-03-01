using Forum.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Commands.Activities
{
    public class UpdateActivity :IRequest
    {
        public Activity activity;
        #region ctor
        public UpdateActivity(Activity activity)
        {
            this.activity = activity;
        }
        #endregion
    }
}
