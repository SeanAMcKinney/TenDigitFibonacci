using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int x = 0;
            int y = 1;
            int z = 0;
            for (int i = 0; i < 45; i++)
            {
                z = x + y;
                x = y;
                y = z;
               
            Console.WriteLine(x);
            }

            Console.WriteLine("Via trial and error: 45th iteration gives x = 1,134,903,170");
        }//end main
    }//end class
}//end name space
