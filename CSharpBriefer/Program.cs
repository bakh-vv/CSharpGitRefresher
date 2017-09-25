using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBriefer
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Integer: " + 10 +
                " Double: " + 3.14 +
                " Boolean: " + true);
            string fooString = "\"escape\" quotes and add \n (new lines) and \t (tabs)";
            Console.WriteLine(fooString);

            char charFromString = fooString[2];
            string fooFs = string.Format("Check Check, {0} {1}, {0} {1:0.0}", 1, 2);
            DateTime fooDate = DateTime.Now;
            Console.WriteLine(fooDate.ToString("hh:mm, dd MMM yyyy"));
            string bazString = @"Here's some stuff
on a new line! ""Wow!"", the masses 
cried";
            const int HoursWorkPerWeek = 9001;
            Console.WriteLine("\n->Operators");
            int i1 = 1, i2 = 2; // Shorthand for multiple declarations

            // Arithmetic is straightforward
            Console.WriteLine(i1 + i2 - i1 * 3 / 7); // => 3
            Console.WriteLine(bazString);
            Console.ReadLine();

            //Change Git
            //Change 2
            
        }
    }
}
