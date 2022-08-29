using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kata.OrderBreaker(new int[] { 2, 1 });
            Kata.OrderBreaker(new int[] { 1, 3, 2 });
            //Kata.OrderBreaker(new int[] { 1, 2, 0, 3, 4 });
            //Kata.OrderBreaker(new int[] { 1001, 991, 992, 993, 994, 995, 996 });
        }
    }

    public class Kata
    {
        public static int OrderBreaker(int[] input) // 1, 2, 0, 3, 4
        {                                           // 0, 1, 2, 3, 4
                                                    // 1, 3, 2, 4, 5
                                                    // 1, 2, 3, 4, 5
            int[] ints = new int[input.Length];
            Array.Copy(input, ints, input.Length);
            Array.Sort(ints);
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] != ints[i])
                {
                    if (input[i] != ints[i+1])
                    {
                        return input[i];
                    }
                }
            }
            return 0;
        }
    }
}
