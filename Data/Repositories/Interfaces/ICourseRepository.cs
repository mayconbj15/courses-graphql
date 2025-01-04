using Courses.GraphQL.Data.Models;

namespace Courses.GraphQL.Data.Repositories.Interfaces;

public interface ICourseRepository
{
    Task<Course> FetchAsync(int id);

    Task<IEnumerable<Course>> FetchAllAsync();

    Task<Course> CreateAsync(Course course);

    Task<Course> UpdateAsync(Course course);

    Task<Course> DeleteAsync(int id);
}
