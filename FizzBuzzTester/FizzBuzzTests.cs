using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLibrary;

namespace FizzBuzzTester
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMinMaxRangeThrowException()
        {
            FizzBuzzLib fizzBuzzLib = new FizzBuzzLib {Min = 100, Max = 10};
            fizzBuzzLib.Run();
        }

        [TestMethod]
        public void TestMinMaxRangeNoThrowException()
        {
            try
            {
                FizzBuzzLib fizzBuzzLib = new FizzBuzzLib { Min = 10, Max = 100 };
                fizzBuzzLib.Run();
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNullWordThrowsException()
        {
            FizzBuzzLib fizzBuzzLib = new FizzBuzzLib();
            List<FizzBuzzLib.FizzBuzzDivisorAssociation> fizzBuzzDivisorAssociations = new List<FizzBuzzLib.FizzBuzzDivisorAssociation>();
            
            fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation{Divisor = 1});
            fizzBuzzLib.Run(fizzBuzzDivisorAssociations);
        }

        [TestMethod]
        public void TestGoodWord()
        {
            try
            {
                FizzBuzzLib fizzBuzzLib = new FizzBuzzLib();
                List<FizzBuzzLib.FizzBuzzDivisorAssociation> fizzBuzzDivisorAssociations = new List<FizzBuzzLib.FizzBuzzDivisorAssociation>();

                fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 1, Word = ""});
                fizzBuzzLib.Run(fizzBuzzDivisorAssociations);

                fizzBuzzDivisorAssociations.Add(new FizzBuzzLib.FizzBuzzDivisorAssociation { Divisor = 1, Word = "fizz" });
                fizzBuzzLib.Run(fizzBuzzDivisorAssociations);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}
