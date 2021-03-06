using AutoMapper;
using Vulder.School.Core.Models;
using Vulder.School.Core.ProjectAggregate.School.Dtos;

namespace Vulder.School.Infrastructure.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<AddSchoolModel, Core.ProjectAggregate.School.School>();
        CreateMap<UpdateSchoolModel, Core.ProjectAggregate.School.School>();
        CreateMap<Core.ProjectAggregate.School.School, SchoolItemDto>();
    }
}