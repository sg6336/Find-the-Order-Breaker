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
            //Kata.OrderBreaker(new int[] { 1, 3, 2 });
            //Kata.OrderBreaker(new int[] { 1, 2, 0, 3, 4 });
            //Kata.OrderBreaker(new int[] { 105, 110, 111, 112, 114, 113, 115 });
            //Kata.OrderBreaker(new int[] { 1001, 991, 992, 993, 994, 995, 996 });
            Kata.OrderBreaker(new int[] { 1, 2, 3, 4, -1 });
        }
    }

    public class Kata
    {
        public static int OrderBreaker(int[] input)
        {
            if (input.Length >= 2)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == 0)
                    {
                        if (input[0] > input[1])
                        {
                            return input[0];
                        }
                        continue;
                    }
                    if (i == input.Length - 1)
                    {
                        int len = input.Length;
                        if (input[len - 2] > input[len - 1])
                        {
                            if (input[len - 1] > input[len - 3])
                            {
                                return input[input.Length - 2];
                            }
                            else
                            {
                                return input[input.Length - 1];
                            }
                        }
                        break;
                    }

                    if (input[i] < input[i - 1] && input[i] < input[i + 1])
                    {
                        return input[i];
                    }
                    if (input[i] > input[i - 1] && input[i] > input[i + 1])
                    {
                        if (input[i + 1] > input[i - 1])
                        {
                            return input[i];
                        }
                    }
                }
            }

            return 0;
        }
    }
}

