using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : Entity
    {
        public int Id;
        public string Name;
        public string Email;
        public string Password;
        public DateTimeOffset CreatedAt;
    }
}
