using System.ComponentModel.DataAnnotations;

namespace Academy_ASP_NET_Homework_Course.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
