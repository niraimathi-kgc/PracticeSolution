using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsequtiveNumbers
{
    class LinqNamespace
    {
        public void LinqSpace()
        {
            
            string tmpVal;
            int i, a;
            Console.WriteLine("Enter the number of elements to be added in the array : ");
            a = Convert.ToInt32(Console.ReadLine());
            int[] myNumbers = new int[a];
            Console.WriteLine("Enter the values in array : ");
            for(i = 0; i < a; i++)
            {
                Console.WriteLine("Value {0} in array : ",i+1);
                 tmpVal = Console.ReadLine();
                myNumbers[i] = Convert.ToInt32(tmpVal);
            }
            Console.WriteLine();
            Console.Write("The max value of the array is : ");
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.Write("The min value of the array is : ");
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.Write("The Sum value of the array is : ");
            Console.WriteLine(myNumbers.Sum());
            Console.Write("The length of the array is : ");
            Console.WriteLine(myNumbers.Length);  // returns the sum of elements
        }

        
    }
}
