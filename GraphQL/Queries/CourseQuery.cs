using Courses.GraphQL.Data.Repositories.Interfaces;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Queries;

public class CourseQuery : ObjectGraphType
{
    public CourseQuery(ICourseRepository repository)
    {
        Field<ListGraphType<CourseType>>("courses")
            .Description("Returns the list of courses")
            .ResolveAsync(async (ctx) => await repository.FetchAllAsync());

        Field<CourseType>("course")
           .Description("Returns a couse")
           .Argument<NonNullGraphType<IntGraphType>>("id")
           .ResolveAsync(async (ctx) => await repository.FetchAsync(ctx.GetArgument<int>("id")));
    }
}
