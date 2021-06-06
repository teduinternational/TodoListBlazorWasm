using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Api.Data;
using TodoList.Api.Entities;


namespace TodoList.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TodoListDbContext _context;

        public UserRepository(TodoListDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetUserList()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
