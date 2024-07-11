using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int additionOfArray = Sum(10,23,45,21,56,78,89,123,20);
            Console.WriteLine("The sum of elements of array is " +additionOfArray);
            Class1.ConversionFromStringToInt("10h"); //calling tryParse from Class1.cs
            returnMultipleOfTwo(out int num,5);
            // the out parameter allows you to pass the arguments without it being initialized
            //you have to just define a value to the out variable in the called function
            ParamArray.appendString("John","Max","Tom");
            AreaOfTriangle(20,30,10);
        }
       
        static int Sum(params int[] sumArray)
        {
            //params is used when programmer has no idea how many inputs are required
            int sum = 0;
            foreach(int item in sumArray)
            
                sum += item;
            

            return sum;
        }

        static void returnMultipleOfTwo(out int num,int times) {

            num = 2;
            for(int i = 1; i<=times; i++)
            
                Console.WriteLine($"{num} * {i} = {num*i}");
        }

        static void AreaOfTriangle(in int length,in int breadth,in int height)
        {
            
            double area = 0.5*length*breadth*height;
            Console.WriteLine("The area of the triangle is : " +area);

            /*Here the in parameter will ensure that the arguments passed by user is 
            readonly and cannot be modified by the function*/
        }
    }
}
