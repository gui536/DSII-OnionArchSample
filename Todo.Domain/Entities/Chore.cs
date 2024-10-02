using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Validation;

namespace Domain.Entities
{
    sealed class Chore : Entity
    {
        private int id;
        private string name;
        private string description;
        private DateTime dueDate;
        private Status status;
        private User assignedTo;

        private void ValidateDomain(string name, string description, 
            DateTime dueDate, Status status,
            User assignedTo)
        {
            DomainExcepetionValidation.When(name.Length == 0, "Nome não pode ser vazio");
            DomainExcepetionValidation.When(dueDate.Year > DateTime.Now.AddYears(3).Year, 
                "Não podem ser criadas tarefas para depois de três anos");
        }
    }


}
