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

            /*
            //### Step 1
            int Step1 = WordCalc.myWordLength("Hi, there!");
            //### Step 2
            double returnMyNumber = WordCalc.ReturnMyNumber(33);
            //### Step 3
            double simpleSum = WordCalc.SimpleSum(2, 3);
            //### Step 4
            double multipleSum = WordCalc.MultipleSum();
            //### Step 5 
            int sumHandleDelimiters = WordCalc.SumHandlingDelimiters("1,2\n3",5);
            //### Step 6 
            sumHandleDelimiters = WordCalc.SumHandlingDelimiters("//;\n1;2",6);
            //### Step 7
            Console.WriteLine($"All numbers entered sums = {WordCalc.MultiplePositiveSum(7)}");
            //### Step 8
            Console.WriteLine($"All numbers entered sums = {WordCalc.MultiplePositiveSum(8)}");
            //### Step 9 
            sumHandleDelimiters = WordCalc.SumHandlingDelimiters("//[***]\n1***2***3",9);
            //### Step 10 
            sumHandleDelimiters = WordCalc.SumHandlingDelimiters("//[*][%]\n1*2%3",10);
            //### Step 11
            sumHandleDelimiters = WordCalc.SumHandlingDelimiters("//[***][#][%]\n1***2#3%4",11);
            //### Step 12
            sumHandleDelimiters = WordCalc.SumHandlingDelimiters("//[*1*][%]\n1*1*2%3",12);
            */


            //### Step 1

            Console.WriteLine("Step #1 > Create a simple string calculator with a method that takes a string and returns a number.");
            int result = WordCalc.add("Hi, there!",1);
            //### Step 2
            double result2 = WordCalc.ReturnMyNumber(33);
            //### Step 3
            Console.WriteLine("Step #3 > Two numbers return the sum of the numbers.");
            result = WordCalc.add("12", 3);
            //### Step 4
            Console.WriteLine("Step #4 > Any amount of numbers returns the sum of those numbers.");
            result = WordCalc.add("3,5,3,9", 4);
            //### Step 5 
            Console.WriteLine("Step #5 > New line breaks and commas should be interchangeable between numbers.");
            result = WordCalc.add("3\n5\n3,9", 5);
            //### Step 6 
            Console.WriteLine("Step #6 > Support different delimiters - to change a delimiter, the beginning of the string will contain a separate line");
            result = WordCalc.add("//;\n1;2", 6);
            //### Step 7
            Console.WriteLine($"All numbers entered sums = {WordCalc.MultiplePositiveSum(7)}");
            //### Step 8
            Console.WriteLine($"All numbers entered sums = {WordCalc.MultiplePositiveSum(8)}");
            //### Step 9 
            Console.WriteLine("Step #9 > Delimiters can be of any length with the following format.");
            result = WordCalc.add("//[***]\n1***2***3", 9);
            //### Step 10 
            Console.WriteLine("Step #10 > Allow multiple delimiters...  ");
            result = WordCalc.add("//[*][%]\n1*2%3", 10);
            //### Step 11
            Console.WriteLine("Step #11 > Handle multiple delimiters with a length longer than one character.");
            result = WordCalc.add("//[***][#][%]\n1***2#3%4", 11);
            //### Step 12
            Console.WriteLine("Step #12 > Handle delimiters that have numbers as part of them, where the number cannot be on the edge of a delimiter.");
            result = WordCalc.add("//[*1*][%]\n1*1*2%3", 12);

            Console.WriteLine("\n\n THAT'S IT...............\n\n");
            //Console.ReadKey(true);
        }

    }

    public static class WordCalc
    {
        //### Step 1 
        public static int myWordLength(string word)
        {
            Console.WriteLine("\n\nStep #1/12 Create a simple string calculator with a method that takes a string and returns a number. :)");
            Console.WriteLine($"The string is:{word}\n");
            //Console.WriteLine($"Type a word: ");
            //word = Console.ReadLine();
            var res = word.Count();
            Console.WriteLine($"The word lenght is: <<< {res} >>>");   
            return res;
        }

        //### Step 2
        public static double ReturnMyNumber(double number)
        {   Console.WriteLine($"Step #2/12 A single number returns that number \nType a number: ");
            //double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Your number is:{number}\n");
            return number;
        }

        //## Step 3 
        public static double SimpleSum(double a, double b)
        {
            Console.WriteLine($"\n\nStep #3/12 Two numbers return the sum of the numbers: ");
            //Console.WriteLine($"Enter operator A:");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Enter operator B:");
            //double b = Convert.ToDouble(Console.ReadLine());
            double res = a + b;
            Console.WriteLine($"{a} + {b} = {res}");
            return res;
        }

        public static double MultipleSum()
        {
            Console.WriteLine($"\n\nStep #4/12 Any amount of numbers returns the sum of those numbers: ");
            //Console.WriteLine($"All numbers entered sums = {WordCalc.MultipleSum()}");
            double mynumber = new double();
            double[] numbs = new double[100];
            int i = 0;
            //Console.WriteLine($"Enter numbers OR Press 0 to Exit:");

            do
            {
                //mynumber = Convert.ToDouble(Console.ReadLine());
                numbs[i] = mynumber;
                i++;
            }
            while (mynumber != 0);
            

            return Sum_MultipleNumbers(numbs); // numbs.Sum();
        }

        public static double Sum_MultipleNumbers(double[] n) 
        {
            return n.Sum();
        }

        internal static object ReturnMyNumber(bool v)
        {
            throw new NotImplementedException();
        }

        public static int SumHandlingDelimiters(string a,int step)
        {
            Console.WriteLine($"\n\nSteps #{step}: New line breaks and commas should be interchangeable between numbers. : ");
            Console.WriteLine($"The string is:{a}");
            
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

            Console.WriteLine($"The sum equals to: {val}");
            return val;
        }

        public static int add(string a, int step)
        {
            Console.WriteLine($"The string is: '{a}'");
            //Console.WriteLine($"Enter a few numbers including line breaks, eg: 1,2\\n3 ");
            //word = Console.ReadLine();

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
            Console.WriteLine($"The word length is: {a.Length}");
            Console.WriteLine($"The sum equals to: {val}\n");
            return val;
        }

        public static double MultiplePositiveSum(int step)
        {

            double mynumber;
            double[] numbs = new double[100];
            int i = 0;

            if (step == 7)
            {
                Console.WriteLine($"\n\nStep #{step} Any amount of POSITIVE numbers returns the sum of those numbers: ");
                do
                {
                    mynumber = Convert.ToDouble(Console.ReadLine());
                    if (mynumber >= 0 )
                    {
                        numbs[i] = mynumber;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"Negative numbers are not allowed. You've entered:{mynumber}\n");
                    }
                }
                while (mynumber != 0);
            }
            else if (step == 8)
            {
                Console.WriteLine($"\n\nStep #{step} Numbers greater or equal to 1000 should be ignored: ");
                Console.WriteLine($"Enter numbers OR Press 0 to Exit:");
                do
                {
                    mynumber = Convert.ToDouble(Console.ReadLine());
                    if (mynumber < 1000)
                    {
                        numbs[i] = mynumber;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine($"Numbers greater than 999 are not allowed. You've entered:{mynumber}");
                    }
                }
                while (mynumber != 0);
            }                
            
            return Sum_MultipleNumbers(numbs); 
        }
    }
}