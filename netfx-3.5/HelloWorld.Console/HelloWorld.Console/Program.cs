using System.Collections.Generic;
using static System.Console;

namespace HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "hello", "world" };
            WriteLine($"{values[0]} {values[1]}");
        }
    }
}
