﻿///////// 
/////  Задача S2_001  -  Написать программу которая выводит случайное 3х значное число и удаляет 2ю цифру этого числа.
///////// 

// 456 -->  46

// Первый метод математический (1й вариант)
/*
int number = new Random().Next(100, 1000); // последнее число которое будет взято 999
Console.WriteLine(number);
Console.WriteLine($"Число без второй цифры имеет вид: {number/100}{number%10}");
*/

// Первый метод математический (2й вариант)
/*
int number = new Random().Next(100, 1000); // последнее число которое будет взято 999
int result = (number/100) * 10 + number%10;
Console.WriteLine(number);
Console.WriteLine(result);
*/

// Второй метод строковый
/*

Console.WriteLine ("Введи 3х значное число: ");
string Numbers = Console.ReadLine()!;

if (Numbers.Length != 3 )
{
    Console.WriteLine("Введено неверное число");
}
else
{
    Console.WriteLine($"Число без второй цифры имееет вид: {Numbers[0]}{Numbers[2]}");
}
// строка от 1 до бес, ;№;:*, ЛДПФЦКПРФКМТ 
// массив только цифры от 1 до беск.
*/

///////// 
/////  Задача S2_002  - 
///////// 

/*
int number = new Random().Next(10, 100); // генерит 2х значное число
Console.WriteLine(number); // вывод на печать его
if (number/10 > number%10) // сравнивает 1й и 2й символы . 
{
    Console.WriteLine(number/10); //если 1й символ > 2го тогд печать 1го
} 
else
{
    Console.WriteLine(number%10); //если 1й символ < 2го тогд печать 2го
}
*/

///////// 
/////  Задача S2_003  - проверить 2х значное число кратный ли 1й символ 2му(кратный ли 1й символ второму) делится ли без остатка
///////// 

/*
Console.WriteLine("Введите 1e 2х значное число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2t 2х значное число: ");
int B = int.Parse(Console.ReadLine()!);
if (A % B == 0)
{
    Console.WriteLine($"{A} кратно {B}");
}
else
{
    Console.WriteLine($"{A} не кратно {B} остаток {A % B}");
}
*/

/////////////////////////////////////////////////////////////////////////////////////////////////
//   Логическое "И"  -   &&  (Одновременно выполняются) // if(n1 % 2 == 0 && 0 & n1 > 0)   else
//   Логическое "ИЛИ" -   ||  (Выполняется 1 из условий либо 2) //  if ( n1 % 2 = 0 || n1 > 0)  else 
///////////////////////////////////////////////////////////////////////////////////////////////////////


///////// 
/////  Задача S2_004  -  проверить кратно ли число 7 и 23
///////// 



// Console.WriteLine("Введите число: ");

// int N1 = int.Parse(Console.ReadLine()!);

/*

if (N1 % 7  == 0 &&  N1 % 23 == 0)
{
    Console.WriteLine($"Число {N1} является кратным числам 7 и 23");
}
else
{
    Console.WriteLine($"Число {N1} НЕ является кратным числам 7 и 23");
}

*/

///////// 
/////  Задача S2_004  -  проверить является ли 1е число квадратом 2го и являтся ли 2е число квадратом 1го
///////// 

// Console.WriteLine("Введите 1е число: ");

// int N1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите 2е число: ");

// int N2 = int.Parse(Console.ReadLine()!);

// if ( N1 == N2 * N2 || N2 == N1 * N1)

// {
//     Console.WriteLine("Одно из чисел является квадратом другого");
// }
// else
// {
//     Console.WriteLine("Ни одно из чисел не является квадратом другого");
// }