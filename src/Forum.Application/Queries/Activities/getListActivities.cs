using Forum.Application.Models;
using Forum.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Application.Queries.Activities
{
    public class getListActivities:IRequest<Result<List<Activity>>>
    {
    }
}
