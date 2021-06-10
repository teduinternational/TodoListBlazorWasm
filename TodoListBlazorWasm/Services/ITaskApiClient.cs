using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.Models.SeedWork;

namespace TodoListBlazorWasm.Services
{
    public interface ITaskApiClient
    {
        Task<PagedList<TaskDto>> GetTaskList(TaskListSearch taskListSearch);

        Task<PagedList<TaskDto>> GetMyTasks(TaskListSearch taskListSearch);


        Task<TaskDto> GetTaskDetail(string id);

        Task<bool> CreateTask(TaskCreateRequest request);
        Task<bool> UpdateTask(Guid id, TaskUpdateRequest request);

        Task<bool> AssignTask(Guid id, AssignTaskRequest request);

        Task<bool> DeleteTask(Guid id);
    }
}
