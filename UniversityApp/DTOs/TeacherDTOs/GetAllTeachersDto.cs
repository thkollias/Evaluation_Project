namespace UniversityApp.DTOs.TeacherDTOs;

public class GetAllTeachersDto : BaseTeacherDto
{
    public int Age { get; set; }
    public override string FirstName { get; set; } = null!;
    public override string LastName { get; set; } = null!;
}