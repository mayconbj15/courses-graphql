using Courses.GraphQL.Data.Models;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types;

public class ReviewType : ObjectGraphType<Review>
{
    public ReviewType()
    {
        Field(x => x.Id, typeof(IdGraphType))
            .Description("Id property from the review object");
        Field(x => x.Comment, typeof(StringGraphType))
            .Description("Cooment property from the review object");
        Field(x => x.Rate, typeof(IntGraphType))
            .Description("Rate property from the review object");
    }
}
