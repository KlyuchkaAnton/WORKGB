// Однострочный комментарий
//Console.WriteLine("Hello!");
/*
многострочный комментарий
22
222
222
*/

// 111
// 11
// 1

//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)

// Вариант 1

// Console.WriteLine("Ведите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int sqr = number * number;
// Console.WriteLine($"Квадрат числа {number} = {sqr}");

// Вариант 2

// Console.WriteLine("Ведите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
// Console.WriteLine($"Квадрат числа {number} = {sqr1}");


// Задание: Вывести все целые числа от -N до N


// Console.WriteLine("Ведите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int N2 = - N;

// while (N2 <= N)
// {
//     Console.Write($"{N2} ");
//     N2++;
// }


// Задание: Принять на вход 3х значное число и на выходе показать последний знак этого числа.

// Console.WriteLine("Ведите 3х значное число: ");
// int N = int.Parse(Console.ReadLine()!);
// int S = N%10;
// Console.Write($"Третье {S} ");

// Задание: Принять на вход 2 числа и проверить является ли первое чиcло квадратом второго.

Console.WriteLine("Ведите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ведите число B: ");
int B = int.Parse(Console.ReadLine()!);
if (A==B/A)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

// Задание: Выдать названия дней недели по заданному номеру