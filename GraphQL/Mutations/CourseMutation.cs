using Courses.GraphQL.Data.Models;
using Courses.GraphQL.Data.Repositories.Interfaces;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Mutations;

public class CourseMutation : ObjectGraphType
{
    public CourseMutation(ICourseRepository repository)
    {
        Field<CourseType>("addCourse")
            .Description("Is used to add a new course to the database")
            .Argument<NonNullGraphType<CourseInputType>>("course")
            .Description("Course input parameter")
            .ResolveAsync(async (ctx) =>
            {
                var course = ctx.GetArgument<Course>("course");
                await repository.Create(ctx.GetArgument<Course>("course"));
                return course;
            });

    }
}
