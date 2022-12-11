// СЕМИНАР 7

///////////////////////////////////////////////////////////////////////////////////////
// Задача 46: Задайте двумерный массив размера m на n, заполненный случайными целыми числами
///////////////////////////////////////////////////////////////////////////////////////

/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray (rows, columns, 0, 10);

PrintArray(array);


//------------------------------------------методы---------------------------------------//


// метод создания двумерного  массива

int[,] GetArray(int m, int n, int minValue, int maxValue){

int[,] result = new int [m, n ];

for(int i = 0; i < m; i++){   // проход по строкам
    for ( int j = 0; j < n; j++){  // проход по столбцам
        result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
} 

// метод печати двумерного  массива

void PrintArray(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

*/
 ///////////////////////////////////////////////////////////////////////////////////////
 // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5
 ///////////////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom (rows, columns, 0, 100);

PrintArray(array);

//------------------------------------------методы---------------------------------------//

// метод создания двумерного  массива

int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue){
int[,] array = new int [sizeM, sizeN ];
for(int i = 0; i < sizeM; i++){   // проход по строкам

    for ( int j = 0; j < sizeN; j++){  // проход по столбцам

        array[i, j] = i+j;
        // result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
} 

// метод печати двумерного   массива

void PrintArray(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom (rows, columns, 0, 100);

PrintArray(array);
GetArrayMethod(array);
Console.WriteLine("==================");
PrintArray(array);

//------------------------------------------методы---------------------------------------//

// метод создания двумерного  массива

int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue){
int[,] array = new int [sizeM, sizeN ];
for(int i = 0; i < sizeM; i++){   // проход по строкам

    for ( int j = 0; j < sizeN; j++){  // проход по столбцам

        array[i, j] = i+j;
        // result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
} 

// метод печати двумерного   массива

void PrintArray(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// метод  

void GetArrayMethod(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
             if (i%2==0 && j%2==0) array[i,j]=(int) Math.Pow(array[i,j],2);
        }
    }
}
*/



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom (rows, columns, 0, 100);

PrintArray(array);
GetArrayMethod(array);
Console.WriteLine("==================");
PrintArray(array);
GetDiag(array);
//------------------------------------------методы---------------------------------------//

// метод создания двумерного  массива

int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue){
int[,] array = new int [sizeM, sizeN ];
for(int i = 0; i < sizeM; i++){   // проход по строкам

    for ( int j = 0; j < sizeN; j++){  // проход по столбцам

        array[i, j] = i+j;
        // result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
} 

// метод печати двумерного   массива

void PrintArray(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($" {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// метод  

void GetArrayMethod(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
             if (i%2==0 && j%2==0) array[i,j]=(int) Math.Pow(array[i,j],2);
        }
    }
}
 
void GetDiag(int[,] array){
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if ( i == j){
                Console.Write($"{array[i, j]} + ");
                sum = sum + array[i, j];
            }
        }
    }
    Console.Write($"Сумма = {sum}");

}
*/


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Также задача: Задать двумерный массив и отсортировать нечетные столбцы по возрастанию
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

 /*
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom (rows, columns, 0, 10);

PrintArray(array);
// GetArrayMethod(array);
Console.WriteLine("==================");
// PrintArray(array);
// GetDiag(array);
GetSortColumnNec(array);
PrintArray(array);

//------------------------------------------методы---------------------------------------//

// метод создания двумерного  массива

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

// метод  

void GetArrayMethod(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
             if (i%2==0 && j%2==0) array[i,j]=(int) Math.Pow(array[i,j],2);
        }
    }
}
 
void GetDiag(int[,] array){
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if ( i == j){
                Console.Write($"{array[i, j]} + ");
                sum = sum + array[i, j];
            }
        }
    }
    Console.Write($"Сумма = {sum}");

}

void GetSortColumnNec(int[,] array){
    for (int j=0; j<array.GetLength(0); j++){
        if(j%2 != 0){
            bool flag=true;
            while(flag){
                flag=false;
                for (int i = 0; i < array.GetLength(0)-1; i++ )
                    if(array[i, j] > array[i+1, j]){
                        int stakan = array [i, j];
                        array[i, j] = array[i+1, j];
                        array[i+1, j] = stakan;
                        flag = true;
            }
         }
      }
  }
}   

*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Задать двумерный массив из целых чисел. Найти средне арифметическое элементов в каждом столбце.
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
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
            Console.Write($"  {(sum / array.GetLength(0)):f2}  ");
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
*/