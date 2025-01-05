using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Courses.GraphQL.Data.Models;

[Table("reviews")]
public class Review
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("rate")]
    public int Rate { get; set; }

    [Column("comment")]
    public string Comment { get; set; }

    [Column("courseid")]
    public int CourseId { get; set; }
    [ForeignKey("CourseId")]
    public Course Course { get; set; }
}
