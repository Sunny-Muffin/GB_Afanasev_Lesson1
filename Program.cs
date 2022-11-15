class Program
{
    static string welcomeText = "Здравствуйте! Вас приветствует математическая программа";
    static string requestText = "Для выполнения расчет введите целое число \nДля завершения программы введите \"q\"";

    static string warningText = "Это не целое число, пожалуйста повторите ввод: ";

    static string resultText1 = "Факториал равен: ";
    static string resultText2 = "Сумма от 1 до N равна: ";
    static string resultText3 = "Mаксимальное четное число меньше N равно: ";


    static void Main(string[] args)
    {
        Welcome();
        int userNumber = AskForNumber();
        (int fact, int sum, int max) = MakeCalculations(userNumber);
        PrintResults(fact, sum, max);
        Console.ReadLine();
    }

    static void Welcome()
    {
        Console.WriteLine(welcomeText);
        Console.WriteLine(requestText);
    }

    public static int AskForNumber()
    {
        string userInput;
        int userNum;

        while (!Int32.TryParse(userInput = Console.ReadLine(), out userNum))
        {
            if (userInput == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(warningText);
            }
        }

        return userNum;
    }

    public static (int, int, int) MakeCalculations(int num)
    {
        int factorial = 1; // хранит факториал числа введенного пользователем
        int sum = 0; // хранит сумму всех чисел до введенного пользователем
        int maxEven = 0; // хранит наибольшее четное число до введенного пользователем
        for (int i = 1; i <= num; ++i)
        {
            factorial *= i;
            sum += i;
            if (i % 2 == 0)
            {
                maxEven = i;
            }
        }
        return (factorial, sum, maxEven);
    }

    public static void PrintResults(int f, int s, int m)
    {
        Console.WriteLine(resultText1 + f);
        Console.WriteLine(resultText2 + s);
        Console.WriteLine(resultText3 + m);
    }
}
