// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.WriteLine("Ведите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите число B: ");
int B = int.Parse(Console.ReadLine()!);

int MAX = A;

if (MAX > B)
{
     Console.WriteLine($"Максимальное число {MAX} ");
}
else
{
    Console.WriteLine($"Максимальное число {B} ");
}
*/



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


/*
Console.WriteLine("Ведите число A: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Ведите число C: ");
int C = int.Parse(Console.ReadLine()!);

int MAX = A;

if (B > MAX)
{
    MAX = B;
}
if (C > MAX)
{
    MAX = C;
}

Console.WriteLine($"Максимальное число {MAX} ");
*/


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*

Console.WriteLine("Ведите число: ");
int A = int.Parse(Console.ReadLine()!);

int X = A % 2; 
int Y = 0;

if (X == Y)
{
    Console.WriteLine($"Число  {A} четное ");
}
else
{
    Console.WriteLine($"Число  {A} нечетное ");
}

*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.WriteLine("Ведите число: ");

int X = int.Parse(Console.ReadLine()!);

int Y=1;

while (Y <= X)
{
    if (Y%2==0)
        {
            Console.Write($"{Y} ");
        }       
    
    Y++;
}
*/