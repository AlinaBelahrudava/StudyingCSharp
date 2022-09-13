using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTasks.Exceptions
{
    public class RemoveAutoException : Exception
    {
        public RemoveAutoException(string message) :
        base(message)
        {
        }
    }
}
