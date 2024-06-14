using System.ComponentModel.DataAnnotations;

namespace UniversityApp.Models.Sessions;

public class Session
{
    
    [Required(ErrorMessage = $"{nameof(Start)}  is required!")]
    public DateTime Start { get; set; }
    
    
    [Required(ErrorMessage = $"{nameof(Duration)}  is required!")]
    public TimeSpan Duration { get; set; }
}