using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types;

public class ReviewInputType : InputObjectGraphType<Review>
{
    public ReviewInputType()
    {
        Name = "ReviewInputType";

        Field<StringGraphType>("Comment")
            .Description("Comment property from the review object");
        Field<IntGraphType>("Rate")
            .Description("Rate property from the course object");
    }
}
