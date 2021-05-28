using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TodoList.Api.Entities;

namespace TodoList.Api.Data
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { set; get; }
    }
}
