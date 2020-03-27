using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCF_Visual
{
    class Program
    {
            static void Main(string[] args)
            {
            Console.WriteLine("Welcome to this program which will give you the Greatest Common  Factor of two numbers.\n " +
                "We will be using Euclids Algorithm for this");
            Console.WriteLine("Please write the two numbers, you wish to find the GCF of, seperated by a space");

            while (true)
            {
                string numbers = Console.ReadLine();
                string[] numbersSplit;
                bool ContainsASpace = numbers.Contains(" ");
                if (ContainsASpace) /* 1 */
                {
                    numbersSplit = numbers.Split(' ');

                    bool ContainsOnlyNumbers = (numbersSplit[0] + numbersSplit[1]).All(char.IsDigit);

                    if (ContainsOnlyNumbers && numbersSplit.Length == 2) /* 2a, 2b */
                    {

                        int numberA = Convert.ToInt32(numbersSplit[0]);
                        int numberB = Convert.ToInt32(numbersSplit[1]);

                        int result = GCF(numberA, numberB);
                        Console.WriteLine("The GCF of " + numberA + " and " + numberB + " is " + result);
                    }
                    else
                    {
                        Console.WriteLine("Please write two whole numbers");
                    }
                }
                else
                {
                    Console.WriteLine("Please write two whole numbers");
                }
            }
            }

            private static int GCF(int a, int b)
            {
                if (a > b) /* 3 */
            {
                    return Algorithm(a, b);
                }
                else
                {
                    return Algorithm(b, a);
                }
            }

            private static int Algorithm(int a, int b)
            {
                int rest = a % b;

                if (rest == 0) /* 4 */
            {
                    return b;
                }
                else
                {
                    return Algorithm(b, rest);
                }
            }
    }
}
