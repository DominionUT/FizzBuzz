using System;
using System.Collections.Generic;

namespace FizzBuzzLibrary
{
    public class FizzBuzzLib
    {
        public FizzBuzzLib()
        {}

        public void Run(string threeString, string fiveString)
        {
            WriteToConsole(threeString, fiveString);
        }

        public void Run()
        {
            WriteToConsole("fizz", "buzz");
        }

        private void WriteToConsole(string threeString, string fiveString)
        {
            if (Min > Max)
                throw new Exception("Min must be less than or equal to Max");

            for (int i = Min; i <= Max; i++)
            {
                Console.Write(i);
                if (i % 3 == 0)
                    Console.Write(" " + (string.IsNullOrEmpty(threeString) ? "fizz" : threeString));
                if (i % 5 == 0)
                    Console.Write(" " + (string.IsNullOrEmpty(fiveString) ? "buzz" : fiveString));
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void Run(List<FizzBuzzDivisorAssociation> fizzBuzzDivisors)
        {
            if (Min > Max)
                throw new Exception("Min must be less than or equal to Max");

            if (fizzBuzzDivisors != null && fizzBuzzDivisors.Count > 0)
            {
                for (int i = Min; i <= Max; i++)
                {
                    Console.Write(i);
                    foreach (var divisor in fizzBuzzDivisors)
                    {
                        if (divisor.Word == null)
                            throw new Exception("Word cannot be null");
                        if (i % divisor.Divisor == 0)
                            Console.Write(" " + divisor.Word);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }

        public struct FizzBuzzDivisorAssociation
        {
            public int Divisor { get; set; }
            public string Word { get; set; }
        }

        public int Min { get; set; }
        public int Max { get; set; }
    }
}
