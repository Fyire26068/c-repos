using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4AG
{
    class Program
    {
        static void Main(string[] args)
        {
            //whole number data types
            byte byteVar; //stored 1 byte in memory and hold a number up 255 ; example age, birthday

            sbyte sbyteVar; // -128 to 127

            short shortVar; // -32,768 to 32,767

            int intVar; // stores 4 bytes if memory; -2,147,483,648 to 2,147,483,647

            uint uintVar; // 0 to 4,294,967,295

            long longVar; // -9,223,372,036,854,775,508 to 9,223,372,036,854,775,807

            ulong ulongVar; // 0 to 18,446,744,073,709,551,615

            byteVar = 255;

            //fract numbers
            float floatVar; //-3.4 x 10^38 to 3.4 x 10^38 (with 7 significant digits)

            double doubVar; //-1.7 x 10^308 to 1.7 x 10^308 (with 15-16 significant digits)

            decimal decVar; //-7.9 x 10^28 to 7.9 x 10^28 (with 28-29 significant digits)

            floatVar = 1.02f;
            decVar = 1.02m;
            doubVar = 1.02;

            //non numeric data
            char charVar; //stores 2 bytes, 1 character

            bool boolVar; //1 byte, true or false

            charVar = 'A';
            boolVar = false;

        }
    }
}
