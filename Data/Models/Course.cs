using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Courses.GraphQL.Data.Models;

[Table("courses")]
public class Course
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("dateadded")]
    public DateTime DateAdded { get; set; }

    [Column("dateupdated")]
    public DateTime DateUpdated { get; set; }

    public List<Review> MyProperty { get; set; }
}
