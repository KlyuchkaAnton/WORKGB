/////////
// Задача 
/////////

/////////
// Задача нахождения максимального числа классическим стихийным методом
/////////

/*
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2023;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

int max = a1;

if ( b1 > max ) max = b1;
if ( c1 > max ) max = c1;

if ( a2 > max ) max = a2;
if ( b2 > max ) max = b2;
if ( c2 > max ) max = c2;

if ( a3 > max ) max = a3;
if ( b3 > max ) max = b3;
if ( c3 > max ) max = c3;

Console.WriteLine(max);
*/

/////////
// Задача нахождения максимального числа с помощью метода №1
/////////

/*

int Max( int arg1, int arg2, int arg3 )
{
    int result = arg1 ;
    if ( arg2 > result ) result = arg2;
    if ( arg3 > result ) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max (max1, max2, max3);

Console.WriteLine(max);

*/

/////////
// Задача нахождения максимального числа с помощью метода функции №2
/////////


/*

int Max( int arg1, int arg2, int arg3 )
{
    int result = arg1 ;
    if ( arg2 > result ) result = arg2;
    if ( arg3 > result ) result = arg3;
    return result;
}

int a1 = 112125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max 
( 
    Max(a1, b1, c1), 
    Max(a2, b2, c2), 
    Max(a3, b3, c3)
);

Console.WriteLine(max);

*/

/////////
// Задача нахождения максимального числа с массивом
/////////

/*

int Max( int arg1, int arg2, int arg3 )
{
    int result = arg1 ;
    if ( arg2 > result ) result = arg2;
    if ( arg3 > result ) result = arg3;
    return result;
}

//             0   1  2  3  4  5  6  7  6
int[] array = {11,211,31,41,15,61,17,18,19};

int result = Max (
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]),
    Max (array[6], array[7], array[8])
                );
            
Console.WriteLine( result );

*/


/////////
// Задача : Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find.
/////////

/*


//              0  1   2  3   4   5   6   7
int[] array = {1, 12, 31, 4, 18, 16, 17, 18}; // задаем массив. индексы массива всегда считаются с 0

int n = array.Length; // задаем переменную n равной длинне массива. столько будет итерраций

int find = 18; // число которое будем искать

int index = 0; // задаем счетчик indeх с начальным значением 0 т.к. элементы в массиве начинаются с индекса "0"

while (index < n)
{
    if (array [index] == find ) // Если индекс совпадет с числом в find то на печать пойдет индекс массива 
    {
        Console.WriteLine(index);
        break; // остановить выполнение программы
    }

    index++; //index = index + 1;
}

*/



/////////
// Задача :  заполнение массива случайными числами и вывод на экран этих чисел с помощью методов
/////////
/*

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {


        collection[index]= new Random().Next(1, 10);
        index++; // index = index + 1;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int [10]; // конструкция new int [10] создай новый массив в котором будет 10 элементов. по умолчанию он будет наполнен нулями

FillArray(array); // вызов метода для заполнения массива случайными числами
PrintArray(array); // вызов метода для распечатки массива

*/


/////////
// Задача :  нахождение позиции нужного элемента в массиве с использованием метода
/////////

/*

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {


        collection[index]= new Random().Next(1, 10);
        index++; // index = index + 1;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // вносим -1 для того чтобы объснить то , 
                        //что в массиве нет искомого элемента. соответственно, 
                        // если видим -1 это значит, что элемента нет в массиве
    while (index < count)
    {
        
        if (collection[index] == find)
        {
                position = index;
                break;
        }
        index++;
    }
    return position;
}
int[] array = new int [10]; // конструкция new int [10] создай новый массив в котором будет 10 элементов. по умолчанию он будет наполнен нулями
FillArray(array); // вызов метода для заполнения массива случайными числами

array[4]=4; // искусственно вносим 4ку на 4ю позицию для того чтобы наглядно протестировать программу
array[6]=4; // искусственно вносим 4ку на 6ю позицию для того чтобы наглядно протестировать программу

PrintArray(array); // вызов метода для распечатки массива
Console.WriteLine();

int pos = IndexOf(array,  444);
Console.WriteLine(pos);

*/