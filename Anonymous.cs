using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablesNAnonymousDemo
{
    class Anonymous
    {
       public void details()
        {
            try
            {
                var v = new { name = "Naveen", Number = 123, money = 45.67 };
                Console.WriteLine(v.name + "-" + v.Number + "-" + v.money);
                // The type of the variable is decided after it is assigned a value
                int a = 0;
                int b = 10;
                int c = b / a;
                Console.WriteLine(c);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
