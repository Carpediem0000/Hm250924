using Hm250924.Models;
using Microsoft.EntityFrameworkCore;

namespace Hm250924.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
