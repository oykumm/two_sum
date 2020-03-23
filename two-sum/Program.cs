/*Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.*/

using System;
using System.Collections.Generic;

namespace two_sum
{
    class Program
    {
    static void Main(string[] args)
        {
            int i, target;
            int[] n = new int[10];
            int[] v = new int[10];
            for (i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Enter {0}. number ", i + 1);
                n[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the target ={0}");
                target = Convert.ToInt32(Console.ReadLine());
                v = TwoSum(n, target);
                Console.WriteLine("v ={0}",v);
                Console.ReadKey();

            }


        }
        public static int[] TwoSum(int[] numbers, int t)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (dict.ContainsKey(t - numbers[i])) // checks if compliment is in dict
                {
                    return new int[] { dict[t - numbers[i]], i };
                }
                else if (!dict.ContainsKey(numbers[i])) // handles duplicates in array
                {
                    dict.Add(numbers[i], i);
                }
            }

            return null;
        }
    }
}
