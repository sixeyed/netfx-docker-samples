using static System.Console;

namespace HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //use C# 7 feature:
            var valueTuple = ("hello", "world");
            WriteLine($"{valueTuple.Item1} {valueTuple.Item2}");
        }
    }
}
