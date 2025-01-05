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

    public async Task<Course> CreateAsync(Course course)
    {
        await _context.Courses.AddAsync(course);

        await _context.SaveChangesAsync();

        return course;
    }

    public async Task<Course> DeleteAsync(int id)
    {
        var course = new Course { Id = id };
        _context.Courses.Remove(new Course { Id = id });

        await _context.SaveChangesAsync();

        return course;
    }

    public async Task<Course> FetchAsync(int id)
    {
        return await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Course>> FetchAllAsync()
    {
        return _context.Courses.Include(c => c.Reviews);
    }

    public async Task<Course> UpdateAsync(Course course)
    {
        _context.Courses.Update(course);

        await _context.SaveChangesAsync();

        return course;
    }
}
