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
        public void FizzbuzzTest()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);
                int maxNum = 300;
                program.FizzBuzz(maxNum);
                string expected = null;
                var newLine = Environment.NewLine;

                for (int i = 1; i <= maxNum; i++)
                {
                    if (i == 42)
                    {
                        expected += string.Format($"Answer to the Ultimate Question of Life, the Universe, and Everything{newLine}");
                    }
                    else if (i % 3 == 0 && i % 5 == 0)
                    {
                        expected += string.Format($"Fizzbuzz{newLine}");
                    }
                    else if (i % 3 == 0)
                    {
                        expected += string.Format($"Fizz{newLine}");
                    }
                    else if (i % 5 == 0)
                    {
                        expected += string.Format($"Buzz{newLine}");
                    }
                    else
                    {
                        expected += string.Format($"{i}{newLine}");
                    }
                }
                Assert.AreEqual(expected, stringWriter.ToString());
            }
        }
    }
}
