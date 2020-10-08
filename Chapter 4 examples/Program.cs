using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_examples
{
    class Contact
    {
        public String name;
        public String number;
        public String homeAddress;
        public String workAddress;
        public String email;
        public byte age;
        
        public void display()
        {
            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(homeAddress);
            Console.WriteLine(workAddress);
            Console.WriteLine(email);
            Console.WriteLine(age);
        }


    }

    

    class Program
    {
        static void Main(string[] args)
        {
            String myString = "Any string must be wrapped \" \"";
            String myString2 = "any string must be wrapped \" \"";

            Console.WriteLine(myString.Equals(myString2, StringComparison.OrdinalIgnoreCase));

            String Letters = "             abcdefghijklmnopqrstuvwxyz";
            String Letters2 = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine(Letters.Length);

            Letters = Letters.Trim();

            Letters = Letters.Replace("e", " ");

            Console.WriteLine(Letters.Substring(6, 5));

            Console.WriteLine(Letters);
            
            
            
            Console.ReadLine();
        }
    }
}
