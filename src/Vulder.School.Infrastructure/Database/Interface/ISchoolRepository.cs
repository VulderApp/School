namespace Vulder.School.Infrastructure.Database.Interface;

public interface ISchoolRepository
{
    Task<Core.ProjectAggregate.School.School> GetSchoolById(Guid schoolId);
    Task<long> GetSchoolDocumentsCount();
    Task<long> GetSchoolsDocumentsCountWithPagination(string input);
    Task<List<Core.ProjectAggregate.School.School>> GetSchoolsWithPagination(int page);
    Task<List<Core.ProjectAggregate.School.School>> GetSchoolsByInput(string input);
    Task<List<Core.ProjectAggregate.School.School>> GetSchoolsByInputWithPagination(string input, int page);
    Task Create(Core.ProjectAggregate.School.School school);
    Task<bool> Update(Core.ProjectAggregate.School.School school);
    Task<bool> Delete(Guid id);
}