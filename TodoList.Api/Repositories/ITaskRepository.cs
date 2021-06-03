using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Api.Entities;
using TodoList.Models;
using Task = TodoList.Api.Entities.Task;

namespace TodoList.Api.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Task>> GetTaskList();

        Task<Task> Create(Task task);

        Task<Task> Update(Task task);

        Task<Task> Delete(Task task);

        Task<Task> GetById(Guid id);

        Task<List<User>> GetUserList();
    }
}
