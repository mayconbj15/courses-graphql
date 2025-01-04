using Courses.GraphQL.GraphQL.Mutations;
using Courses.GraphQL.GraphQL.Queries;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL;

public class AppSchema : Schema
{
    public AppSchema(CourseQuery query, CourseMutation mutation)
    {
        Query = query;
        Mutation = mutation;
    }
}
