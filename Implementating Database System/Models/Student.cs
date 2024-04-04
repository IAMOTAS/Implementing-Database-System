// Student.cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student
{
    public int StudentID { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }

    // Navigation property for Enrollments
    public List<Enrollment> Enrollments { get; set; }
}
