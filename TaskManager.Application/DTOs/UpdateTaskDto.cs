namespace TaskManager.Application.DTOs;

public class UpdateTaskDto
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public int Priority { get; set; }
    public DateTime? ScheduledDate { get; set; }
    public Guid CategoryId { get; set; }
}
