using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erfly.App
{
    public class TresholdException : Exception
    {
        public TresholdException(string message) : base(message)
        {

        }
    }
}
