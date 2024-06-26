using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Задача по условиям 1: Сравнение двух чисел
        Console.WriteLine("Введите первое число:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 == number2)
        {
            Console.WriteLine("Числа равны.");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("Первое число больше второго.");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго.");
        }

        // Задача по условиям 2: Проверка числа в диапазоне от 5 до 10
        Console.WriteLine("Введите число:");
        int number3 = Convert.ToInt32(Console.ReadLine());
        if (number3 >= 5 && number3 <= 10)
        {
            Console.WriteLine("Число больше 5 и меньше 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }

        // Задача по условиям 3: Проверка числа на равенство 5 или 10
        Console.WriteLine("Введите число:");
        int number4 = Convert.ToInt32(Console.ReadLine());
        if (number4 == 5 || number4 == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10.");
        }
        else
        {
            Console.WriteLine("Неизвестное число.");
        }

        // Задача по условиям 4: Расчет вклада с процентами
        Console.WriteLine("Введите сумму вклада:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        double finalAmount;
        if (depositAmount < 100)
        {
            finalAmount = depositAmount * 1.05;
        }
        else if (depositAmount <= 200)
        {
            finalAmount = depositAmount * 1.07;
        }
        else
        {
            finalAmount = depositAmount * 1.10;
        }
        Console.WriteLine("Сумма вклада с процентами: " + finalAmount);

        // Задача по условиям 5: Выбор операции
        Console.WriteLine("Введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
        int operation = Convert.ToInt32(Console.ReadLine());
        switch (operation)
        {
            case 1:
                Console.WriteLine("Сложение");
                break;
            case 2:
                Console.WriteLine("Вычитание");
                break;
            case 3:
                Console.WriteLine("Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена.");
                break;
        }

        // Задачи по циклам 1: Расчет вклада с процентами по месяцам
        Console.WriteLine("Введите сумму вклада:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < months; i++)
        {
            deposit *= 1.07m;
        }
        Console.WriteLine("Конечная сумма вклада: " + deposit);

        // Задачи по циклам 2: Таблица умножения
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write((i * j) + "\t");
            }
            Console.WriteLine();
        }

        // Задачи по циклам 3: Проверка и произведение чисел в диапазоне 0-10
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
            {
                Console.WriteLine("Произведение: " + (num1 * num2));
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Попробуйте снова.");
            }
        }

        // Задачи по массивам 1: Вывод нечетных чисел из массива
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Нечетные числа в массиве:");
        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }

        // Задачи по массивам 2: Поиск строки в массиве строк
        string[] stringArray = { "apple", "banana", "cherry" };
        Console.WriteLine("Введите строку для поиска:");
        string searchString = Console.ReadLine();
        if (stringArray.Contains(searchString))
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }

        // Задачи по массивам 3: Сумма и среднее арифметическое массива чисел
        int[] numbersArray = { 1, 2, 3, 4, 5 };
        int sum = numbersArray.Sum();
        double average = numbersArray.Average();
        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое элементов массива: " + average);

        // Ожидание ввода пользователя для предотвращения закрытия консоли.
        Console.ReadLine();
    }
}
