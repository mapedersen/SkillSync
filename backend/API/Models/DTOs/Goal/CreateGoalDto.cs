using System.ComponentModel.DataAnnotations;

namespace API.Models.DTOs.Goal;

public class CreateGoalDto
{
    [Required]
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string? Category { get; set; }
}