namespace UniversityApp.DTOs.TeacherDTOs;

public class CreateTeacherDto : BaseTeacherDto
{
    public CreateTeacherDto()
    {
        IdCounter++;
    }
    private static int IdCounter { get; set; }
    public int Id { get; private set; } = IdCounter;
    public override string FirstName { get; set; } = null!;
    public override string LastName { get; set; } = null!;
}