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

    public async Task<Course> Delete(int id)
    {
        var course = new Course { Id = id };
        _context.Courses.Remove(new Course { Id = id });

        await _context.SaveChangesAsync();

        return course;
    }

    public async Task<Course> Get(int id)
    {
        return await _context.Courses.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Course>> GetAll()
    {
        return _context.Courses;
    }

    public async Task<Course> Update(Course course)
    {
        _context.Courses.Update(course);

        await _context.SaveChangesAsync();

        return course;
    }
}
