using MongoDB.Driver;
using Vulder.School.Infrastructure.Database.Interface;

namespace Vulder.School.Infrastructure.Database.Repository;

public class SchoolRepository : ISchoolRepository
{
    private IMongoCollection<Core.ProjectAggregate.School.School> Schools { get; }
    
    public SchoolRepository(MongoDbContext context)
    {
        Schools = context.Schools;
    }

    public async Task Create(Core.ProjectAggregate.School.School school)
    {
        await Schools.InsertOneAsync(school);
        await Schools.Indexes.CreateOneAsync(
            new CreateIndexModel<School.Core.ProjectAggregate.School.School>(Builders<School.Core.ProjectAggregate.School.School>.IndexKeys.Text(s => s.Name))
            );
    }

    public async Task<List<Core.ProjectAggregate.School.School>> GetSchoolsByInput(string input)
        => await Schools.Find(Builders<School.Core.ProjectAggregate.School.School>.Filter.Text(input)).Limit(10).ToListAsync();
}