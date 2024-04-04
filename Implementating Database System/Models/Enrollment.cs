// Enrollment.cs
using System;
using System.ComponentModel.DataAnnotations;

public class Enrollment
{
    public int EnrollmentID { get; set; }

    public int StudentID { get; set; }
    public Student Student { get; set; }

    public int CourseID { get; set; }
    public Course Course { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EnrollmentDate { get; set; }
}
