using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHandson.Arrays.Beginner
{
    public class ArrayMaxValue
    {
        public static int? getMaxValue(int[] numbers)
        {
            if (numbers == null)
            {
                Console.WriteLine("Error: Array cannot be null.");
                return null;
            }

            if (numbers.Length == 0)
            {
                Console.WriteLine("Error: Array cannot be empty.");
                return null;
            }
            int maxValue = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i]; // Update maxValue if current number is greater
                }
            }
            return maxValue;
        }
        public static void Main(string[] arg)
        {
            int[] numbers = { };
            int? max = getMaxValue(numbers);
            if (max == null)
            {
                Console.WriteLine("Please give proper values to array");
            }
            else
            {
                Console.WriteLine($"Max Value is:{max}");
            }
            Console.ReadKey();
        }
    }
}
