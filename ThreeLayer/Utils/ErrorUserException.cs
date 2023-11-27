using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayer.Utils
{
    internal class ErrorUserException : Exception
    {
        public ErrorUserException() : base("This account is already exist") {
        
        }
    }
}
