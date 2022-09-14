using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTasks.Exceptions
{
    public class AddException : ArgumentException
    {
        public AddException(string message) :
            base(message)
        {
        }
    }
}
