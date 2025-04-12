using TaskManager.Application.DTOs;
using TaskManager.Domain.Entities;
using TaskManager.Domain.Repositories;

namespace TaskManager.Application.Services;

public class TaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<IEnumerable<TaskDto>> GetAllAsync()
    {
        var tasks = await _taskRepository.GetAllAsync();

        return tasks.Select(t => new TaskDto
        {
            Id = t.Id,
            Title = t.Title,
            Description = t.Description,
            ScheduledDate = t.ScheduledDate,
            Priority = t.Priority,
            CategoryId = t.CategoryId
        });
    }

    public async Task<TaskDto?> GetByIdAsync(Guid id)
    {
        var task = await _taskRepository.GetByIdAsync(id);
        if (task is null) return null;

        return new TaskDto
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            ScheduledDate = task.ScheduledDate,
            Priority = task.Priority,
            CategoryId = task.CategoryId
        };
    }

    public async Task<TaskDto> CreateAsync(CreateTaskDto dto)
    {
        var task = new TaskItem
        {
            Title = dto.Title,
            Description = dto.Description,
            Priority = dto.Priority,
            CategoryId = dto.CategoryId,
            ScheduledDate = null // Algoritmo automático pode agendar mais tarde
        };

        await _taskRepository.AddAsync(task);

        return new TaskDto
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            ScheduledDate = task.ScheduledDate,
            Priority = task.Priority,
            CategoryId = task.CategoryId
        };
    }

    public async Task<bool> UpdateAsync(Guid id, UpdateTaskDto dto)
    {
        var task = await _taskRepository.GetByIdAsync(id);
        if (task is null) return false;

        task.Title = dto.Title;
        task.Description = dto.Description;
        task.Priority = dto.Priority;
        task.ScheduledDate = dto.ScheduledDate;
        task.CategoryId = dto.CategoryId;

        await _taskRepository.UpdateAsync(task);
        return true;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var task = await _taskRepository.GetByIdAsync(id);
        if (task is null) return false;

        await _taskRepository.DeleteAsync(id);
        return true;
    }
}
