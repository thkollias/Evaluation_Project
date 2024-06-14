using UniversityApp.Models.Students;

namespace UniversityApp.Models.Employees;

internal class BoardingMember : Employee
{
    public override int Id { get; init; }
    public override string FirstName { get; set; } = null!;
    public override string LastName { get; set; } = null!;
    public override int Age { get; set; }
    public override double Wage { get; set; }
    public override DateTime StartDate { get; set; }

    public List<Student> Students { get; set; } = [];
    public List<Teacher> Teachers { get; set; } = [];
}