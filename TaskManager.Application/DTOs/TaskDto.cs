namespace TaskManager.Application.DTOs;

public class TaskDto {
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public DateTime? ScheduledDate { get; set; }
    public int Priority { get; set; }
    public Guid CategoryId { get; set; }
}