using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Validation;

namespace Domain.Entities
{
    public class Chore : Entity
    {
        private int id;
        private string name;
        private string description;
        private DateTime dueDate;
        private Status status;
        private User assignedToId;

        private void ValidateDomain(string name, string description, 
            DateTime dueDate, Status status,
            User assignedToId)
        {
            DomainExcepetionValidation.When(name.Length == 0, "Nome não pode ser vazio");
            DomainExcepetionValidation.When(assignedToId == null, "Toda tarefa deve ter um usuário atribuído");
            DomainExcepetionValidation.When(dueDate.Year > DateTime.Now.AddYears(3).Year, 
                "Não podem ser criadas tarefas para depois de três anos");
            DomainExcepetionValidation.When(dueDate.Year < DateTime.Now.Year,
       "Não podem ser criadas tarefas para dias que já se passaram");
        }
    }
}
