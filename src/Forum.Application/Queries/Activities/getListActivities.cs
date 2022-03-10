using Forum.Application.Models;
using Forum.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Forum.Application.Queries.Activities
{
    public class getListActivities : IRequest<Result<List<Activity>>>
    {
    }
}