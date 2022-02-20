using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealOrderSystem.API.Infrastructure.Entities
{
    /// <summary>
    /// Meal entity
    /// </summary>
    public class MealEntity
    {
        /// <summary>
        /// Meal Id
        /// </summary>
        [Key]
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Meal name
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [ForeignKey("MealType")]
        public MealTypeEntity MealType { get; set; }

        /// <summary>
        /// Meal type id
        /// </summary>
        [Column("meal_type_id")]
        public int MealTypeId { get; set; }
    }
}
