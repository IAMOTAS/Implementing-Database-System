// Course.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Course
{
    public int CourseID { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    [StringLength(50)]
    public string Instructor { get; set; }

    // Navigation property for Enrollments
    public List<Enrollment> Enrollments { get; set; }
}
