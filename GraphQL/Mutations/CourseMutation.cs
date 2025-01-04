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
            .Argument<NonNullGraphType<CourseInputType>>("course", "Course input parameter")
            .Description("Course input parameter")
            .ResolveAsync(async (ctx) =>
                await repository.Create(ctx.GetArgument<Course>("course"))
            );

        Field<CourseType>("updateCourse")
            .Description("Is used to update a new course to the database")
            .Argument<NonNullGraphType<IdGraphType>>("id", "Course id")
            .Argument<NonNullGraphType<CourseInputType>>("course", "Course input parameter")
            .Description("Course input parameter")
            .ResolveAsync(async (ctx) =>
            {
                var course = ctx.GetArgument<Course>("course");
                course.Id = ctx.GetArgument<int>("id");
                await repository.Update(ctx.GetArgument<Course>("course"));

                return course;
            }
            );
    }
}
