using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minValue = nums =>
            {
                int minNum = int.MaxValue;
                foreach (int num in nums)
                {
                    if (num < minNum)
                    {
                        minNum = num;

                    }
                    
                }
                return minNum;
            };
            Console.WriteLine(minValue(numbers));
        }
        static int GetMin(int[] nums)
        {
            int minNum = int.MaxValue;
            foreach (int num in nums)
            {
                if (num < minNum)
                {
                    minNum = num;

                }
                
            }
            return minNum;
        }
    }
}
