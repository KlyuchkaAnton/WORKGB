// ДЗ К СЕМИНАРУ №7

///////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
///////////////////////////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("Введите количество строк: ");
int rows= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array =  GetArray (rows, columns); // создаем двумерный массив из вещественных чисел  вызывая метод


PrintArray(array); // вызываем метод печати массива. пока он не наполнен будут нули


//-------------------------методы-------------------//



//---------метод наполнения  массива-----------\\

double[,] GetArray (int rows, int columns){

double[,] result = new double [rows, columns];
 Random rand = new Random();
for(int i = 0; i < rows; i++){   // проход по строкам
    for ( int j = 0; j < columns; j++){  // проход по столбцам
        Console.WriteLine($"Введите элемент массива [{i},{j} ]");
        result[i, j] = double.Parse(Console.ReadLine()!); // вводим с клавиатуры числа дробные , не ставить " . " а то ошибка!!
        // result[i, j] =rand.NextDouble(); // автоматическое заполнение случайными числами
        }
    }
    return result;
} 

//---------метод печати массива-----------\\

void PrintArray(double[,] array){

for ( int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        double x = array[i, j];
        Console.Write ($"  {Math.Round(x, 1)} ");
    }
    Console.WriteLine();
}
}
 */

///////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9
///////////////////////////////////////////////////////////////////////////////////////////////////
 
/*

Console.WriteLine("Введите количество строк от 1 до 3: ");
    int rows= int.Parse(Console.ReadLine()!);
    if (rows >0 && rows< 4)
        {
     Console.WriteLine($"Число строк: {rows}"); 
        }  
    else
        {
        Console.WriteLine("Неправильное число строк!Попробуйте снова!");
        return;
        }

Console.WriteLine("Введите количество столбцов от 1 до 4: ");
int columns = int.Parse(Console.ReadLine()!);
    if (columns>0 && columns<5)
        {
     Console.WriteLine($"Число столбцов: {columns}"); 
        }  
    else
        {
        Console.WriteLine("Неправильное число столбцов! Попробуйте снова!");
        return;
        }

int[,] array =  GetArray (rows, columns); // создаем двумерный массив из целых чисел  вызывая метод и передаем ему значения 


PrintArray(array); // вызываем метод печати массива. пока он не наполнен будут нули


//---------  печать заданного элемента двумерного массива по заданным индексам----------\\


Console.WriteLine($"Введите индекс строки элемента массива от 0 до {rows-1}: ");

    int row= int.Parse(Console.ReadLine()!);

    if (row > -1 && row < rows+1)
        {
    Console.WriteLine($"Индекс строки для печати: {row}"); 
        }  
    else
        {
        Console.WriteLine("Такого индекса строки не существует!Попробуйте снова!");
        return;
        }


Console.WriteLine($"Введите индекс столбца от 0 до {columns-1}: ");
int column = int.Parse(Console.ReadLine()!);
    if (column > -1 && column < columns+1)
        {
     Console.WriteLine($"Индекс столбца для печати:  {column}"); 
        }  
    else
        {
        Console.WriteLine("Такого индекса столбца не существует! Попробуйте снова!");
        return;
        }

Console.WriteLine($"Индекс {array[row, column]}");


//-------------------------методы-------------------//


//---------метод наполнения  массива-----------\\

int[,] GetArray (int rows, int columns) // объявляем метод
{
int[,] result = new int [rows, columns];
 
for(int i = 0; i < rows; i++)  // проход по строкам
    {  
    for ( int j = 0; j < columns; j++) // проход по столбцам
        {  
            Console.WriteLine($"Введите элемент массива [{i},{j} ]");
            result[i, j] = int.Parse(Console.ReadLine()!); // вводим с клавиатуры числа 
             
        }
    }
    return result;
} 

//---------метод печати массива-----------\\

void PrintArray(int[,] array){

for ( int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
        int x = array[i, j];
        Console.Write ($"  { x } ");
    }
    Console.WriteLine();
}
}
 
 
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom (rows, columns, 0, 10);
PrintArray(array);
GetAvgColumn(array);


//-----------------------------------------------------------------
int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue){
int[,] array = new int [sizeM, sizeN ];
for(int i = 0; i < sizeM; i++){   // проход по строкам

    for ( int j = 0; j < sizeN; j++){  // проход по столбцам

        // array[i, j] = i+j;
        array[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
} 

//-----------------------------------------------------------------

void GetAvgColumn(int[,] array)
{
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i, j];
            }
            Console.Write($"  {Math.Round((sum / array.GetLength(0)), 2)}"); // округляем число до сотых
        }
    }
    Console.WriteLine("]");
}

// метод печати двумерного   массива

void PrintArray(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        Console.Write("[") ;
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine("]");
    }
}

