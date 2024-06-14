using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Models.Employees;

public abstract class Employee
{
    [Key] public abstract int Id { get; init; }

    [Required]
    [StringLength(20, ErrorMessage = $"{nameof(FirstName)} maximum length is 20")]
    public abstract string FirstName { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = $"{nameof(LastName)} maximum length is 20")]
    public abstract string LastName { get; set; }

    public abstract int Age { get; set; }

    public abstract double Wage { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}"/*, ApplyFormatInEditMode = true*/)]
    public abstract DateTime StartDate { get; set; }
}