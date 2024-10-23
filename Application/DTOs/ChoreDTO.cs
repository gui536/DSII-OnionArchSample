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
        private int id;
        [Required(ErrorMessage = "Nome da tarefa é obrigatório")]
        [MinLength(1)]
        [MaxLength(100)]
        private string name;
        private string description;
        private DateTime dueDate;
        [Required(ErrorMessage = "Status da tarefa é obrigatório")]        
        private Status status;
        [Required(ErrorMessage = "Toda tarefa deve ter um usuário atribuído é obrigatório")]
        private User assignedToId;
    }
}
