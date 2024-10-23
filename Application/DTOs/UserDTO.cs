using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class UserDTO
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        [EmailAddress]
        public string Email { get; set; }
        [PasswordPropertyText]
        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Password { get; set; }
        [DataType(DataType.DateTime)]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
