﻿///////////////////////////////////______________________________/////////////////////////////////// 
///////////////////////////////////___ДЗ К СЕМИНАРУ 3 C#_________/////////////////////////////////// 
///////////////////////////////////______________________________/////////////////////////////////// 
/////////////////////////////////////////////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, 
//будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

/*

Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!); // конвертация строки в целочисленный тип int
int G = A;

Console.WriteLine("Введите степень: ");
int C = int.Parse(Console.ReadLine()!); // конвертация строки в целочисленный тип int
int F = C;

Console.WriteLine($"Число {G} в степени {F} равно {Step(F)} ");

//---------------------------------- МЕТОДЫ-----------------------------------------

int Step (int Z)
{
int H = 1;

for (int B = 1; B <= Z; B++)
{
    H *= G;
    Console.WriteLine(H);
}
return H;
}

*/
//////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

 
 /*

Console.WriteLine();
Console.Write("Введите число: ");

string s = Console.ReadLine()!;
Console.WriteLine();

SummaChisel (s) ;
 
int SummaChisel (string s)
{

            int[] mass = new int[s.Length];

            Console.WriteLine($"Размер массива равен количеству символов в числе {s} т.е. {s.Length}");
            Console.WriteLine();
           
            int summ = 0;

            for (int i = 0; i < s.Length; i++)
            {
                mass[i] = int.Parse(s[i].ToString());
            }
 
            for (int i = 0; i < mass.Length; i++)
            {
                summ = mass[i] + summ;
            }

            Console.WriteLine($"Сумма цифр в числе {s} равна {summ}");
            Console.WriteLine();
            return summ;
}

*/


/////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)


int[] array = new int[8];

Mass ( array ) ; // вызываем метод

Console.WriteLine();

Console.WriteLine ($"Массив из случайных чисел: {String.Join("  ",array)}"); 

Console.WriteLine();

 int[] Mass ( int[] array ) // МЕТОД ЗАПОЛНЕНИЯ МАССИВА СЛУЧАЙНЫМИ ЧИСЛАМИ

    {
        for ( int i = 0; i < array.Length; i++ )
            {
                array[i] = new Random().Next(0, 9);
            }
            return array;
    }

