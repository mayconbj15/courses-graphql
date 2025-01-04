using Courses.GraphQL.Data.Models;

namespace Courses.GraphQL.Data.Repositories.Interfaces;

public interface ICourseRepository
{
    Task<Course> Get(int id);

    Task<IEnumerable<Course>> GetAll();

    Task Create(Course course);

    Task Update(Course course);

    Task Delete(int id);
}
