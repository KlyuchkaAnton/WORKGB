///  SEMINAR - 3
/////////////////////////////////////////////////////////////////////////////////////////////////
//   Логическое "И"  -   &&  (Одновременно выполняются) // if(n1 % 2 == 0 && 0 & n1 > 0)   else
//   Логическое "ИЛИ" -   ||  (Выполняется 1 из условий либо 2) //  if ( n1 % 2 = 0 || n1 > 0)  else 
///////////////////////////////////////////////////////////////////////////////////////////////////////

////
//// ЗАДАЧА_C#_С3-1 -  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
////

/*

Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!); // не будет 0-м никогда

switch (number)
{
    case 1:
        {
            Console.WriteLine("Это 1-ая четверть!");
            break;
        }
    case 2:
        {
            Console.WriteLine("Это 2-ая четверть!");
            break;
        }
    case 3:
        {
            Console.WriteLine("Это 3-ая четверть!");
            break;
        }
    case 4:
        {
            Console.WriteLine("Это 4-ая четверть!");
            break;
        }        
    default:
        {
            Console.WriteLine("Такой четверти не существует!"); 
            break;  
        }
}

*/

////
//// ЗАДАЧА_C#_С3-2 -  Является ли заданное 6-ти значное число счастливым (сумма первых 3х цифр равна сумме его последних 3х цифр )
////

// ЗАДАЧА_C#_С3-2  * МАТЕМАТИЧЕСКИЙ СПОСОБ

/*
Console.WriteLine("Введите шестизначное число:  ");
int number = int.Parse(Console.ReadLine()!); // ! означает что число никогда не равно "0".
int n1 = number/1000; // выделяем 1е 3и знака числа. т.к. int то после деления останется только числа слева от запятой 123,456 = 123
Console.WriteLine($"{n1}");
Console.WriteLine($"{n1%10}");
int n2 = number-n1*1000; // выделяем 2е 3и знака числа . из основного числа мы вычитаем первые три знака 123456 - (123 * 1000) = 0,456 . 
                         //т.к. int то после вычитания останется только числа справа от запятой 0,456  = 456
Console.WriteLine($"{n2}");

if (number/100000 > 0  &&  number/100000 < 9) 
{
    if (n1/100 + (n1/10-n1/100*10)+n1%10 == n2/100+(n2/10 - n2/100*10)+n2%10) 
    
        Console.WriteLine("Счастливое число");
    
    else  
    
        Console.WriteLine("число несчастливое");
}
    
else

Console.WriteLine("число не 6ти значное");
*/

// ЗАДАЧА_C#_С3-2  * ЛОГИЧЕСКИЙ СПОСОБ. СТРОКИ

/*
int num = new Random().Next(100000, 1000000);
Console.WriteLine(num);
string numbers = Convert.ToString(num);
int first = Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]) + Convert.ToInt32(numbers[2]);
int second = Convert.ToInt32(numbers[3]) + Convert.ToInt32(numbers[4]) + Convert.ToInt32(numbers[5]);

if(first == second)
{
    Console.WriteLine("Число счастливое!");
}
else
{
    Console.WriteLine("Число НЕ счастливое!");
}
*/

// ЗАДАЧА_C#_С3-2  * ЛОГИЧЕСКИЙ СПОСОБ. СТРОКИ. ПРОВЕРКА

/*

Console.WriteLine("Введите 6ти значное число: "); 
int number = int.Parse(Console.ReadLine()!); // ввод числа
string number1 = number.ToString();
if (number1.Length != 6)
{
    Console.WriteLine("Такое значение неправильное! ");
}
else
{
    if (number1[0]+ number1[1]+ number1[2] == number1[3]+ number1[4]+ number1[5])
    {
        Console.WriteLine("Число счастливое! ");
    }
    else
    {
        Console.WriteLine("Несчастливое число! ");
    }
}

*/

////
//// ЗАДАЧА_C#_С3-3 -  Напишите программу, которая принимает на вход координаты 2х точек и находит растояние между ними в 2Д пространстве.
////

// A (3, 6); B (2, 1) --> 5.09
// A (7, -5); B (1, -1) --> 7.21

/*

// int[] mas = {3, 6, 2, 1};
int[] mas = {7, -5, 1, -1};

double masR = Math.Sqrt(Math.Pow(mas[0]-mas[2], 2) + Math.Pow(mas[1]-mas[3], 2));

Console.WriteLine($"{masR:f2}");

*/

////
//// ЗАДАЧА_C#_С3-4 -  Напишите программу, которая принимает на вход  число (N) и выдает таблицу квадратов чисел от 1 до N
////

// 5 --> 1, 4, 9, 16, 25
// 2 --> 1, 4

/*

Console.WriteLine("Введите число!");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    Console.WriteLine($"Преобразуем отрицательное число {-num}  в положительное {num} ");
    num =  -num;
    // num = -num;
}
for (int i = 1; i <= num ; i++ )
{
    Console.Write($"{Math.Pow(i, 2)} ");
}

*/
