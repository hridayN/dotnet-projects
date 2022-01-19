using Authentication.API.Infrastructure.Entities.Base;
using Authentication.API.Utility.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication.API.Infrastructure.Entities
{
    /// <summary>
    /// User entity, Table("tablename")
    /// </summary>
    [Table("user", Schema = TableSchema.User)]
    public class UserEntity : Entity
    {
        /// <summary>
        /// User id
        /// </summary>
        [Key]
        [Column("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [Column("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Column("password")]
        public string Password { get; set; }
    }
}
