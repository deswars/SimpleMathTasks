using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace NumberThreePrimeDivider
{
    class Program
    {
        //Find n-th number with only 3 prime divider 
        static void Main(string[] args)
        {
            uint[] multipliers = new uint[] { 2, 3, 5 };
            uint maxIndex = 1000000;
            Console.Write("Input number index(1000000):");
            string input = Console.ReadLine();
            if (uint.TryParse(input, out uint inputInt))
            {
                maxIndex = inputInt;
            }

            uint index = 0;
            var numbers = new SortedDictionary<BigInteger, uint>();
            numbers.Add(1, 0);

            while (index < maxIndex)
            {
                var current = numbers.First();
                numbers.Remove(current.Key);
                for (uint i = current.Value; i < multipliers.Length; i++)
                {
                    numbers.Add(current.Key * multipliers[i], i);
                }
                index++;

                //Console.WriteLine(current.Key + " " + numbers.Count());
                if (index == maxIndex)
                {
                    Console.WriteLine("Number = " + current.Key);
                    Console.WriteLine("Uncheked number list length = " + numbers.Count());
                }
            }
            Console.ReadLine();
        }
    }
}
