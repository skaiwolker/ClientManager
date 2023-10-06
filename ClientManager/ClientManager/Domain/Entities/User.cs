using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public User() : base()
        {
        }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
