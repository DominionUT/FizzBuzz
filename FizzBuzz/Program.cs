using System;
using System.Collections.Generic;
using FizzBuzzLibrary;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            DiviserTesterGoodOne();
            //DiviserTesterGoodTwo();
            //DiviserTesterWillFail();
            //ConsoleTester();
        }

        private static void DiviserTesterGoodOne()
        {
            FizzBuzzLibrary.FizzBuzzLib fizzBuzz = new FizzBuzzLibrary.FizzBuzzLib();
            fizzBuzz.Min = 1;
            fizzBuzz.Max = 100;
            List<FizzBuzzLibrary.FizzBuzzLib.FizzBuzzDivisorAssociation> fizzBuzzDivisorAssociations = new List<FizzBuzzLib.FizzBuzzDivisorAssociation>();
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation{Divisor = 3, Word = "fizz"});
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 5, Word = "buzz" });
            fizzBuzz.Run(fizzBuzzDivisorAssociations);
        }

        private static void DiviserTesterGoodTwo()
        {
            FizzBuzzLibrary.FizzBuzzLib fizzBuzz = new FizzBuzzLibrary.FizzBuzzLib();
            fizzBuzz.Min = 5;
            fizzBuzz.Max = 70;
            List<FizzBuzzLibrary.FizzBuzzLib.FizzBuzzDivisorAssociation> fizzBuzzDivisorAssociations = new List<FizzBuzzLib.FizzBuzzDivisorAssociation>();
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 3, Word = "fizz" });
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 5, Word = "buzz" });
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 7, Word = "WOOHOO" });
            fizzBuzz.Run(fizzBuzzDivisorAssociations);
        }

        private static void DiviserTesterWillFail()
        {
            FizzBuzzLibrary.FizzBuzzLib fizzBuzz = new FizzBuzzLibrary.FizzBuzzLib();
            fizzBuzz.Min = 5;
            fizzBuzz.Max = 70;
            List<FizzBuzzLibrary.FizzBuzzLib.FizzBuzzDivisorAssociation> fizzBuzzDivisorAssociations = new List<FizzBuzzLib.FizzBuzzDivisorAssociation>();
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 3, Word = "fizz" });
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 5 });
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 7, Word = "WOOHOO" });
            fizzBuzz.Run(fizzBuzzDivisorAssociations);
        }

        private static void ConsoleTester()
        {
            FizzBuzzLibrary.FizzBuzzLib fizzBuzz = new FizzBuzzLibrary.FizzBuzzLib();

            Console.WriteLine("Input Min #:");
            fizzBuzz.Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Max #:");
            fizzBuzz.Max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Three String?:");
            string threeString = Console.ReadLine();
            Console.WriteLine("Five String?:");
            string fiveString = Console.ReadLine();

            if (string.IsNullOrEmpty(threeString) && string.IsNullOrEmpty(fiveString))
            {
                fizzBuzz.Run();
            }
                
            else
            {
                fizzBuzz.Run(threeString, fiveString);
            }
        }
    }
}
