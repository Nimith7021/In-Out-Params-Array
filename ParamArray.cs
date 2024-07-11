using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParams
{
    internal class ParamArray
    {
        public static void appendString(params string[] str)
        {
            Console.Write("The names of the people are : ");
            foreach (string name in str)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
