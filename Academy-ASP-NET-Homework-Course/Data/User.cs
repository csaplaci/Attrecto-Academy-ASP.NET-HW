﻿using System.ComponentModel.DataAnnotations;

namespace Academy_ASP_NET_Homework_Course.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }
        public ICollection<Course> Courses { get; set; } = [];
    }
}
