using System.ComponentModel;

namespace TaskManager.Domain.Entities;

public class TaskItem {
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Priority { get; set; }
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }
    public DateTime? ScheduledTime { get; set; }
    public TimeSpan Duration { get; set; }
    public bool isCompleted { get; set; }

}