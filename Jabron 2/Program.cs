using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите программу:\n1 - Игра 'Угадай число'\n2 - Таблица умножения\n3 - Вывод делителей числа\n4 - Выход");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: GuessNumberGame(); break;
                case 2: MultiplicationTable(); break;
                case 3: PrintDivisors(); break;
                case 4: return;
                default: Console.WriteLine("Неверный выбор, попробуйте снова."); break;
            }
        }
    }

    static void GuessNumberGame()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        Console.WriteLine("Угадайте число от 0 до 100.");
        int userNumber;
        do
        {
            userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber > randomNumber) Console.WriteLine("Слишком большое число!");
            else if (userNumber < randomNumber) Console.WriteLine("Слишком маленькое число!");
        } while (userNumber != randomNumber);
        Console.WriteLine("Поздравляем, вы угадали число!");
    }

    static void MultiplicationTable()
    {
        int[,] table = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                table[i, j] = (i + 1) * (j + 1);
            }
        }
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Делители числа:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}