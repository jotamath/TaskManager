namespace TaskManager.Application.DTOs;

public class CreateTaskDto
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public int Priority { get; set; }
    public Guid CategoryId { get; set; }
}
