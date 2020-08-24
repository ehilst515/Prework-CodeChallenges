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
        }
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
            Console.WriteLine("Enter 5 numbers between 1 and 10");
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
        Console.WriteLine("Enter a number between 1 and 10 to get a score");
        var input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        return number;
    }

}