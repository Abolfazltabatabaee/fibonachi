using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//abolfazlabatabaee
                int a = 1;
                int b = 0;
                Console.WriteLine("enter a num mr hazfi");
                int n;

                n = Convert.ToInt32(Console.ReadLine());
                Console.Write(b);
                for (int i = 0; i < n; i++)
                {

                    a = a + b;
                    Console.Write(a);
                    Console.Write(" ");
                    b = a + b;
                    Console.Write(b);
                    Console.Write(" ");
                }
                Console.ReadKey();
            }

        }
    }
}
