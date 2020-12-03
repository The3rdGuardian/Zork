using System;

namespace Zork
{
    internal class ConsolueOutputService : IOutputService
    {
        public void Write(string value)
        {
            Console.Write(value);
        }

        public void Write(object value)
        {
            Write(value.ToString());
        }

        public void WriteLine(string value, bool isBold)
        {
            Console.WriteLine(value);
        }

        public void WriteLine(object value, bool isBold = false)
        {
            WriteLine(value.ToString());
        }
    }
}
