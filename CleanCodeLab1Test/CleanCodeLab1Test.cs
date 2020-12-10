using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodeLab1;
using System.IO;
using System;

namespace CleanCodeLab1Test
{
    [TestClass]
    public class CleanCodeLab1Test
    {
        Program program;

        public CleanCodeLab1Test()
        {
            program = new Program();
        }

        [TestMethod]
        public void UserInputTest()
        {
            using(StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                var userInput = new StringReader("300");
                Console.SetIn(userInput);
                var expected = string.Format("Ange ett heltal mellan 1 och 300: ", Environment.NewLine);
                var actual = stringWriter.ToString();

                program.UserInput();
                Assert.AreNotEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FizzbuzzTest()
        {
            string fizz = "Fizz";
            string buzz = "Buzz";
            string fizzBuzz = "Fizzbuzz";
            string theAnswer = "Answer to the Ultimate Question of Life, the Universe, and Everything";

            var expectedFizz = program.FizzBuzz(24);
            var expectedBuzz = program.FizzBuzz(20);
            var expectedFizzBuzz = program.FizzBuzz(30);
            var expectedAnswer = program.FizzBuzz(42);

            Assert.AreEqual(expectedFizz, fizz);
            Assert.AreEqual(expectedBuzz, buzz);
            Assert.AreEqual(expectedFizzBuzz, fizzBuzz);
            Assert.AreEqual(expectedAnswer, theAnswer);
            
        }
    }
}
