using MealOrderSystem.API.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MealOrderSystem.API.Infrastructure.Entities
{

    /// <summary>
    /// MealType Entity
    /// </summary>
    [Table("meal_type", Schema = DbConstant.MealOrderSystemSchema)]
    public class MealTypeEntity
    {
        /// <summary>
        /// Id for MealType
        /// </summary>
        [Key]
        [Column("meal_type_id")]
        public int MealTypeId { get; set; }

        /// <summary>
        /// MealType name
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}
