using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> addFunc = x => x + 1;
            Func<int, int> multiplayFunc = x => x * 2;
            Func<int, int> subtractFunc = x => x - 1;

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case"add":
                        numbers = numbers.Select(addFunc).ToList();
                        break;
                    case"multyplay":
                        numbers = numbers.Select(multiplayFunc).ToList();
                        break;
                    case "subtract":
                        numbers = numbers.Select(subtractFunc).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ",numbers));
                        break;
                    
                }

                command = Console.ReadLine();
            }
        }
    }
}
