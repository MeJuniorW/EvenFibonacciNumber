using System;
using System.Collections.Generic;

namespace EvenFibNum
{
    internal class Program
    {
        /*Project Euler Problem 2
         * By considering the terms in the Fibonacci sequence whose
         * values do not exceed four million,
         * find the sum of the even-valued terms.
         */

        private static void Main()
        {
            void FindFib()
            {
                // Intialize the first and second terms
                int fstTerm = 1;
                int sndTerm = 1;
                int sum = 0;
                while (sndTerm <= 4000000)
                {
                    int temp = sndTerm;
                    sndTerm = fstTerm + sndTerm;
                    fstTerm = temp;
                    // add up the even numbers and put the value in variable sum
                    if (sndTerm % 2 == 0)
                    {
                        sum += sndTerm;
                        // Console.WriteLine(sum);
                    }
                }
                Console.WriteLine(sum);
            }
            FindFib();
        }
    }
}