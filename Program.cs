using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class Program
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

		
      

        static void Main(string[] args)
        {
            
	    Console.WriteLine( Add(6,3));
	    Console.WriteLine( Multiply(6,3));
        Console.WriteLine(Sub(6, 3));

        }
    }
}
