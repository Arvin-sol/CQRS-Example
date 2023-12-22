using CQRSExample.Domain.Entities;
using CQRSExample.Domain.IRepositories;
using CQRSExample.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Infrastructure.Reposities
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateUserAsync(User model)
        {
            await _context.Users.AddAsync(model);
            return true;
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByID(int id)
        {
            var resualt = await _context.Users.FirstOrDefaultAsync(x => x.ID == id);
            return resualt;
        }
    }
}
