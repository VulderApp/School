using MediatR;
using Vulder.School.Core.ProjectAggregate.School.Dtos;

namespace Vulder.School.Core.Models;

public record UpdateSchoolModel : SchoolModel, IRequest<ResultDto>
{
    public Guid Id { get; set; }
}