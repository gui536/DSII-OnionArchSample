using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ChoreDTO
    {
        public int Id;
        [Required(ErrorMessage = "Nome da tarefa é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name;
        public string Description;
        public DateTime DueDate;
        [Required(ErrorMessage = "Status da tarefa é obrigatório")]
        public Status Status;
        [Required(ErrorMessage = "Toda tarefa deve ter um usuário atribuído")]
        public User AssignedToId;
    }
}
