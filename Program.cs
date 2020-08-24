using System;

namespace PreworkChallenges
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1");
            Console.Write(Environment.NewLine);
            Console.WriteLine($"Final Score: {Challenge1.Score(Challenge1.arrayOfNumbers(), Challenge1.InputNumber())}");
            Console.Write(Environment.NewLine);

            Console.WriteLine("Challenge 2");
            Console.Write(Environment.NewLine);
            Console.WriteLine(Challenge2.LeapYear());
            Console.Write(Environment.NewLine);
        }
    }

    class Challenge1
    {
        public static int Score(int[] numbers, int numberInput)
        {
            int multiplier = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberInput == numbers[i])
                {
                    multiplier++;
                }
            }
            int points = multiplier * numberInput;
            return points;
        }

        public static int[] arrayOfNumbers()
        {
            int[] arrOfNumbers = new int[5];
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                Console.WriteLine("Enter 5 numbers between 1 and 10: ");
                var input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                arrOfNumbers[i] = number;
            }

            foreach (int i in arrOfNumbers)
            {
                Console.WriteLine(i);
            }

            return arrOfNumbers;
        }

        public static int InputNumber()
        {
            Console.WriteLine("Enter a number between 1 and 10 to get a score: ");
            var input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            return number;
        }

    }

    //1. If the year is evenly divisible by 4, go to step 2. Otherwise, go to step 5.
    //2. If the year is evenly divisible by 100, go to step 3. Otherwise, go to step 4.
    //3. If the year is evenly divisible by 400, go to step 4. Otherwise, go to step 5.
    //4. The year is a leap year (it has 366 days).
    //5. The year is not a leap year (it has 365 days).

    class Challenge2
    {
        public static string LeapYear()
        {
            Console.WriteLine("Enter a year");
            var input = Console.ReadLine();
            int year = Convert.ToInt32(input);
            string yes = year + " is a leap year.";
            string no = year + " is not a leap year.";
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    return no;
                }
                else
                {
                    return yes;
                }
            }
            else
                return no;
        }
    }
}