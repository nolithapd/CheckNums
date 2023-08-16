using System;

namespace CheckNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 10;
            string checkNumsResults = checkNums(num1, num2);
            Console.WriteLine(checkNumsResults);
        }
        public static string checkNums(int num1, int num2)
        {
            if (num2 > num1)
            {
                return "true";
            }
            else if (num1 == num2)
            {
                return "-1";
            }
            else
            {
                return "false";
            }

        }
    }
}
