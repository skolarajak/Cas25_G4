using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas25
{
    class ConsoleClass
    {
        static public void ReadInput(int numvalues, out int[] values)
        {
            string input;
            int[] vals = new int[numvalues];
            for (int i = 0; i < numvalues; i++)
            {
                Console.Write("Unesite broj {0} od {1} > ", i + 1, numvalues);
                input = Console.ReadLine();
                vals[i] = Convert.ToInt32(input);
            }
            values = vals;
        }
    }
}
