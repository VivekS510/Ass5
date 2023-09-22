using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Value: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Value: ");
            int second = Convert.ToInt32(Console.ReadLine());
            if (first>=100 & first<=200 || second>=100 && second<=200)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }
        }
    }
}
