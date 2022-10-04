using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_table_of_enter_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  N, M;
            Console.WriteLine("enter any number");
            N = Convert.ToInt32(Console.ReadLine());
            for (M = 1; M <= 10; M++)
            {
                Console.WriteLine("{0}*{1}={2}",N,M,(N*M));
                Console.ReadLine();
            }
        }
    }
}
