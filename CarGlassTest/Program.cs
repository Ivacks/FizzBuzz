using System;
using System.Collections.Generic;
using System.Numerics;

namespace CarGlassTest
{
    class Program
    {
        #region Properties
        public int Number { get; set; }
        public const int ItemsToTest = 100;
        #endregion

        static void Main(string[] args)
        {
            Program mc = new Program();
            //For debugging
            //List<string> watchList = new List<string>(); ;

           for (int Number = 1; Number <= ItemsToTest; Number++)
           {
                string writeMe = mc.TryThreeOrFive(Number);
                //watchList.Add(writeMe);
                Console.WriteLine(writeMe);
           }
        }

        //Method to test if the number is divisible by 3 or 5 || Contains 3 or 5
        public string TryThreeOrFive(int numberToTest)
        {
            string expression;
            if ((numberToTest % 3 == 0 && numberToTest % 5 == 0) || 
                (numberToTest.ToString().Contains("3") && numberToTest.ToString().Contains("5")))
            {
                expression = "FizzBuzz";
            }
            else if (numberToTest % 3 == 0 || numberToTest.ToString().Contains("3"))
            {
                expression = "Fizz";
            } 
            else if (numberToTest % 5 == 0 || numberToTest.ToString().Contains("5"))
            {
                expression = "Buzz";
            }
            else
            {
                expression = numberToTest.ToString();
            }

            return expression;
        }
    }
}
