using System.ComponentModel.DataAnnotations;

namespace API.Models.DTOs;

public class CreateLogDto
{
    [Required]
    public string Title { get; init; } = null!;
    public string? Note { get; init; }
    [Required]
    public int DurationInMinutes { get; init; }
    [Required]
    public Guid GoalId { get; init; }
}
