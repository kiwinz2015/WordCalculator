using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "";
            
            //### Step 1
            Console.WriteLine("\n\nStep #1/12 Create a simple string calculator with a method that takes a string and returns a number. :)");
            Console.WriteLine($"Type a word: ");
            word = Console.ReadLine();
            Console.WriteLine($"The word lenght is: <<< {WordCalc.myWordLength(word)} >>>"); //{word}

            //### Step 2
            Console.WriteLine($"\n\nStep #2/12 A single number returns that number \nType a number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your number is:{WordCalc.ReturnMyNumber(a)}");

            //### Step 3
            Console.WriteLine($"\n\nStep #3/12 Two numbers return the sum of the numbers: ");
            Console.WriteLine($"Enter operator A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter operator B:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A + B = {WordCalc.SimpleSum(a,b)}");

            //### Step 4
            Console.WriteLine($"\n\nStep #4/12 Any amount of numbers returns the sum of those numbers: ");
            Console.WriteLine($"All numbers entered sums = {WordCalc.MultipleSum()}");
            
            //### Step 5 & 6 & 9 & 10 & 11
            Console.WriteLine($"\n\nSteps #5, 6, 9, 10, 11, 12: New line breaks and commas should be interchangeable between numbers. : ");
            Console.WriteLine($"Enter a few numbers including line breaks, eg: 1,2\n3 ");
            word = Console.ReadLine();
            Console.WriteLine($"The sum equals to: {WordCalc.SumHandlingDelimiters(word)}");
            
            //### Step 7 & 8
            Console.WriteLine($"\n\nStep #7/12 Any amount of POSITIVE numbers returns the sum of those numbers: ");
            Console.WriteLine($"All numbers entered sums = {WordCalc.MultiplePositiveSum()}");
            

            //================================ 
            //Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

    }

    public static class WordCalc
    {
        //### Step 1 
        public static int myWordLength(string word)
        {
            var res = word.Count();
            return res;
        }

        //### Step 2
        public static double ReturnMyNumber(double number) => number;

        //## Step 3 
        public static double SimpleSum(double a, double b)
        {
            return a + b;
        }

        public static double MultipleSum()
        {
            double mynumber;
            double[] numbs = new double[100];
            int i = 0;
            Console.WriteLine($"Enter numbers OR Press 0 to Exit:");

            do
            {
                mynumber = Convert.ToDouble(Console.ReadLine());

                numbs[i] = mynumber;

                i++;
            }
            while (mynumber != 0);

            return numbs.Sum();
        }

        internal static object ReturnMyNumber(bool v)
        {
            throw new NotImplementedException();
        }

        public static int SumHandlingDelimiters(string a)
        {
            string b = string.Empty;
            int val = 0;
            
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                {
                    b = a[i].ToString();
                    val = val + int.Parse(b);
                }
            }

            return val;
        }
        
        public static double MultiplePositiveSum()
        {
            double mynumber;
            double[] numbs = new double[100];
            int i = 0;
            Console.WriteLine($"Enter numbers OR Press 0 to Exit:");

            do
            {
                mynumber = Convert.ToDouble(Console.ReadLine());
                if (mynumber > 0 &&  mynumber < 1000)
                {
                    numbs[i] = mynumber;
                    i++;
                }
                else
                {
                    Console.WriteLine($"Negative numbers OR Greater than 999 not allowed. You've entered:{mynumber}");
                }
            }
            while (mynumber != 0);

            return numbs.Sum();
        }
    }
}