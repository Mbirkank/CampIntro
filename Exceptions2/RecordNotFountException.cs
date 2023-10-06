using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    public class RecordNotFountException : Exception
    {
        public RecordNotFountException(string message):base(message)
        {
            
        }
    }
}
