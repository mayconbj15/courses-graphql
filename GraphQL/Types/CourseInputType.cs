using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types;

public class CourseInputType : InputObjectGraphType<Course>
{
    public CourseInputType()
    {
        Name = "CourseInputType";

        Field<StringGraphType>("Description")
            .Description("Description property from the course object");
        Field<StringGraphType>("Name")
            .Description("Name property from the course object");
        Field<DateTimeGraphType>("DateAdded")
            .Description("DateAdded property from the course object");
        Field<DateTimeGraphType>("DateUpdated")
            .Description("DateUpdated property from the course object");

        Field<ListGraphType<ReviewInputType>>("Reviews")
            .Description("Course reviews");
    }
}
