using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablesNAnonymousDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = null; It is not possible to assign null values to variables this can be acheived by using nullable types in C#
            int? a = null; // assigning a null value to the variable type Int.
            if (a.HasValue)
            {
                Console.WriteLine("a contains some values in it");
            }
            else
            {
                Console.WriteLine("a Containes null value in it");
            }
            Anonymous obj = new Anonymous();
            obj.details();
            Console.ReadLine();
            // the use of nullables types is more when reading values from database which contains null values in the table.

        }
    }
}
