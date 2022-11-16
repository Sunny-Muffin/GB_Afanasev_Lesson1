using System;
using System.Numerics;

class Program
{
    static string welcomeText = "Здравствуйте! Вас приветствует математическая программа";
    static string requestText = "Для выполнения расчет введите целое положительное число \nДля завершения программы введите \"q\"";
   
    static string warningText = "Это не целое положительное число, пожалуйста повторите ввод: ";

    static string resultText1 = "Факториал равен: ";
    static string resultText2 = "Сумма от 1 до N равна: ";
    static string resultText3 = "Mаксимальное четное число меньше N равно: ";

    static string quitSymbol = "q";

    static void Main(string[] args)
    {
        Welcome();
        int userNumber = AskForNumber();
        (BigInteger fact, int sum, int max) = MakeCalculations(userNumber);
        PrintResults(fact, sum, max);
        Console.ReadLine();
    }

    static void Welcome()
    {
        Console.WriteLine(welcomeText);
        Console.WriteLine(requestText);
    }

    static int AskForNumber()
    {
        string userInput;
        int userNum = 0;

        while (!Int32.TryParse(userInput = Console.ReadLine(), out userNum) || userNum <= 0)
        {
            Console.WriteLine(userNum);

            if (userInput == quitSymbol)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(warningText);
            }
        }
        Console.WriteLine(userNum);
        return userNum;
    }

    static (BigInteger, int, int) MakeCalculations(int num)
    {
        return (CalculateFactorial(num), CalculateSum(num), CalculateMaxEven(num));
    }

    static BigInteger CalculateFactorial(int n)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= n; ++i)
        {
            factorial *= i;
        }

        return factorial;
    }

    static int CalculateSum(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; ++i)
        {
            sum += i;
        }

        return sum;
    }

    static int CalculateMaxEven(int n)
    {
        int maxEven;

        if (n % 2 == 0)
        {
            maxEven = n;
        }
        else
        {
            maxEven = n - 1;
        }

        return maxEven;
    }

    static void PrintResults(BigInteger f, int s, int m)
    {
        Console.WriteLine(resultText1 + f);
        Console.WriteLine(resultText2 + s);
        Console.WriteLine(resultText3 + m);
    }
}
