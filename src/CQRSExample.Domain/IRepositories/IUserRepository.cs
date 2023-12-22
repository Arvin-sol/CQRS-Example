using CQRSExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSExample.Domain.IRepositories
{
    public interface IUserRepository
    {
        Task<bool> CreateUserAsync(User model);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetByID(int id);

    }
}
