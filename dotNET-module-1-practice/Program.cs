using System;

class Program
{
    static void Main()
    {
        // Задача 1
        Console.Write("Введите ваше имя: ");
        string firstName = Console.ReadLine();

        Console.Write("Введите вашу фамилию: ");
        string lastName = Console.ReadLine();

        string fullName = $"{firstName} {lastName}";
        Console.WriteLine($"Приветствую тебя - {fullName}");

        // Задача 2
        Console.WriteLine("Введите несколько чисел через пробел:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sum = 0;
        foreach (string numberStr in numbers)
        {
            if (int.TryParse(numberStr, out int number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine($"Ошибка: '{numberStr}' не является числом и будет проигнорировано.");
            }
        }

        Console.WriteLine($"Сумма введенных чисел: {sum}");

        Console.WriteLine("Нажмите Enter, чтобы завершить...");
        Console.ReadLine();
    }
}
