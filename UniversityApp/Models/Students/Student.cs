using System.ComponentModel.DataAnnotations;
using UniversityApp.Models.Courses;

namespace UniversityApp.Models.Students;

public class Student
{
    [Key] public int Id { get; init; }
    public DateTime StartDate { get; init; }
    public List<Course> Courses { get; set; } = [];
}