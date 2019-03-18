using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......stack......");

            Stack s1 = new Stack();

            string contains = "";
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
           
           

            Console.WriteLine("....contains....");
            Console.WriteLine("number in the stack");
            contains = Console.ReadLine();
            if (s1.Contains(contains) == true)
            {
                while (s1.Peek().ToString() != contains)
                {
                    Console.WriteLine(s1.Pop()); 
                }
               
            }
            else
            {
                Console.WriteLine("doest not contains" + contains);
            }

            Console.ReadLine(); 
        }
    }
}
