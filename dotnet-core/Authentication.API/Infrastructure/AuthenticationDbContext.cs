using Authentication.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authentication.API.Infrastructure
{
    public class AuthenticationDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AuthenticationDbContext() : base()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// User table
        /// </summary>
        public DbSet<UserEntity> User { get; set; }
    }
}
