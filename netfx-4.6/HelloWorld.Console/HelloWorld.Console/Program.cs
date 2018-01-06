using System.Collections.Generic;
using static System.Console;

namespace HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // use .NET 4.6 feature:
            var values = new Stack<string>();
            values.Push("world");
            values.Push(" ");
            values.Push("hello");   
            
            foreach(var value in values as IReadOnlyCollection<string>)
            {
                Write(value);
            }
            WriteLine();
        }
    }
}
