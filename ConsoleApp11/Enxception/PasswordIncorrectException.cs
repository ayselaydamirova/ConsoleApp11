using System;

namespace ConsoleApp11.Enxception
{
    class PasswordIncorrectException : Exception
    {
        public PasswordIncorrectException(string msj) : base(msj) {}
    }
}
