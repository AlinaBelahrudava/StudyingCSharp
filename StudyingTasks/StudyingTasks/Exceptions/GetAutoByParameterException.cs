using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTasks.Exceptions
{
    public class GetAutoByParameterException : KeyNotFoundException
    {
        public GetAutoByParameterException(String message) :
           base(message)
        {
        }
    }
}
