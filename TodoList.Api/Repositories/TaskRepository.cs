using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList.Api.Data;
using TodoList.Api.Entities;
using TodoList.Models;
using Task = TodoList.Api.Entities.Task;

namespace TodoList.Api.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TodoListDbContext _context;

        public TaskRepository(TodoListDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Entities.Task>> GetTaskList()
        {
            return await _context.Tasks
                .Include(x => x.Assignee).ToListAsync();
        }

        public async Task<Task> Create(Task task)
        {
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<Task> Update(Task task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<Task> Delete(Task task)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<Task> GetById(Guid id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<List<User>> GetUserList()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
