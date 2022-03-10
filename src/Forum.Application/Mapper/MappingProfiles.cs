using AutoMapper;
using Forum.Application.DTOs.Activity;
using Forum.Domain.Entities;

namespace Forum.Application.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ActivityDTO, Activity>();
        }
    }
}