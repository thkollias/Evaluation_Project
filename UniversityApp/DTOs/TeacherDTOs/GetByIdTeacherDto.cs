namespace UniversityApp.DTOs.TeacherDTOs;

internal class GetByIdTeacherDto : BaseTeacherDto
{
    public int Id { get; }
    public override string FirstName { get; set; } = null!;
    public override string LastName { get; set; } = null!;
}