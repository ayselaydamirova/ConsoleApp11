using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp11.Enxception
{
    class InvalidUserNameException: Exception
    {
        public InvalidUserNameException(string msj) : base(msj) {}
    }
}
