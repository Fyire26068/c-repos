using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whateverYouWantConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Anthony";
            Console.WriteLine("Hello " + name);
            Console.WriteLine("What's your last name?");
            String lastName = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " " + lastName);
            Console.ReadLine();
             

        }
    }
}
