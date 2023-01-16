using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******* REVERSE ******
            //string x =   "Dawit";
            //var result = x.ToCharArray().Reverse();
            //Console.WriteLine(new string (result.ToArray()));
            //Console.ReadLine();


            Console.WriteLine("Enter the first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third Number");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", c, b, a);
            Console.ReadLine();

            //Console.Write("Enter a String : ");
            //string inputString = Console.ReadLine();

            //Console.WriteLine("All substrings for given string are : ");

            //for (int i = 0; i < inputString.Length; ++i)
            //{
            //    StringBuilder subString = new StringBuilder(inputString.Length - i);
            //    for (int j = i; j < inputString.Length; ++j)
            //    {
            //        subString.Append(inputString[j]);
            //        Console.Write(subString + " ");
            //    }
            //}
            //Console.ReadLine();

            //Console.Write("Enter the Decimal Number : ");
            //int number = int.Parse(Console.ReadLine());
            //int i;
            //int[] numberArray = new int[10];
            //for (i = 0; number > 0; i++)
            //{
            //    numberArray[i] = number % 2;
            //    number = number / 2;
            //}
            //Console.Write("Binary Represenation of the given Number : ");
            //for (i = i - 1; i >= 0; i--)
            //{
            //    Console.Write(numberArray[i]);
            //}
            //Console.ReadKey();
        }
    }
}
