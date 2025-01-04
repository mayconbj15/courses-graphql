using Courses.GraphQL.Data.Context;
using Courses.GraphQL.Data.Models;
using Courses.GraphQL.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Courses.GraphQL.Data.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Course> Create(Course course)
    {
        await _context.Courses.AddAsync(course);

        await _context.SaveChangesAsync();

        return course;
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Course> Get(int id)
    {
        return await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Course>> GetAll()
    {
        return _context.Courses;
    }

    public Task<Course> Update(Course course)
    {
        throw new NotImplementedException();
    }
}
