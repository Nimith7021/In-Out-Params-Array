using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParams
{
    internal class Class1
    {
        public static void ConversionFromStringToInt(string str)
        {
            if (int.TryParse(str, out int outputNumber))
                Console.WriteLine($"Successfully converted '{str}' to {outputNumber}");
            else
                Console.WriteLine("Failed to convert");
                
        }
    }
}
/*tryparse will return a bool value to denote whether it was successful
in converting the string to integer */