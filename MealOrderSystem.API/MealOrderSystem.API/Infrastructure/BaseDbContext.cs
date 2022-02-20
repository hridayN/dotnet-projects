using MealOrderSystem.API.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace MealOrderSystem.API.Infrastructure
{
    /// <summary>
    /// BaseDbContext class
    /// </summary>
    public class BaseDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseDbContext() : base()
        {
        }

        /// <summary>
        /// Meal table
        /// </summary>
        public DbSet<MealEntity> Meal { get; set; }

        /// <summary>
        /// MealType table
        /// </summary>
        public DbSet<MealTypeEntity> MealType { get; set; }
    }
}
