using UniversityApp.Models.Sessions;

namespace UniversityApp.Models.Employees;

internal class Cleaner : Employee
{
    public override int Id { get; init; }
    public override string FirstName { get; set; } = null!;
    public override string LastName { get; set; } = null!;
    public override int Age { get; set; }
    public override double Wage { get; set; }
    public override DateTime StartDate { get; set; }

    public Dictionary<WeekDays, List<Session>>? WeeklyTasksPerDay { get; set; } = [];
}