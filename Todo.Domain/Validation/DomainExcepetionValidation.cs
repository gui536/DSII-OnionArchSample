using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Validation
{
    public class DomainExcepetionValidation : Exception
    {
        public DomainExcepetionValidation(string error) : base(error) {
        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExcepetionValidation(error);
        }
    }
}
