using CQRSExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace CQRSExample.Infrastructure.Common
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
