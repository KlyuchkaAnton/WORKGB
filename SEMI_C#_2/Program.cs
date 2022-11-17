///////// 
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