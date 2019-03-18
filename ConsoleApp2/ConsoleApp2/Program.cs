using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......stack......");

            Stack s1 = new Stack();

          
            Console.WriteLine("first number ");
            s1.Push(Console.ReadLine());
            Console.WriteLine("second number");
            s1.Push(Console.ReadLine());
            Console.WriteLine("third number");
            s1.Push(Console.ReadLine());
            Console.WriteLine("forth number");
            s1.Push(Console.ReadLine());
            Console.WriteLine("fivth number");
            s1.Push(Console.ReadLine());

            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Console.ReadLine();
        }
        
    }
}
