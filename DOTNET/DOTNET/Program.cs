using System;
using System.Text;

namespace DOTNET
{
    class Program
    {
        static void Main(string[] args)
        {
            //REFERENCE TYPES
            StringBuilder first = new StringBuilder();
            first.Append("hello");
            StringBuilder second = first;
            first.Append(" world");
            Console.WriteLine(second); // Prints hello world

            StringBuilder third = new StringBuilder();
            third.Append("hello");
            StringBuilder fourth = third;
            third.Append(" world");
            third = new StringBuilder("goodbye");
            Console.WriteLine(third); // Prints goodbye
            Console.WriteLine(fourth); // Still prints hello world
        }
    }
}
