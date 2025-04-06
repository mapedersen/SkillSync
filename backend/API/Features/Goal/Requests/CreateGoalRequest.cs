using System.ComponentModel.DataAnnotations;

namespace API.Features.Goal.Requests;

public class CreateGoalRequest
{
    [Required]
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string? Category { get; set; }
}
