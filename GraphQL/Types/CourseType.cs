using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types;

public class CourseType : ObjectGraphType<Course>
{
    public CourseType()
    {
        Field(x => x.Id, typeof(IdGraphType))
            .Description("Id property from the course object");
        Field(x => x.Description, typeof(StringGraphType))
            .Description("Description property from the course object");
        Field(x => x.Name, typeof(StringGraphType))
            .Description("Name property from the course object");
        Field(x => x.Review, typeof(IntGraphType))
            .Description("Review property from the course object");
        Field(x => x.DateAdded, typeof(DateTimeGraphType))
            .Description("DateAdded property from the course object");
        Field(x => x.DateUpdated, typeof(DateTimeGraphType))
            .Description("DateUpdated property from the course object");
    }
}
