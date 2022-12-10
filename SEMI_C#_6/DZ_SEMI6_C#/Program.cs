
// ДЗ К СЕМИНАРУ №6


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*

Console.Clear();

Console.WriteLine("Сколько чисел вы хотите ввести? ");
int M = int.Parse(Console.ReadLine()!);// длинна массива

AmountOfNumbers (M);

void AmountOfNumbers (int MM){

Console.WriteLine($"Количество чисел равно = {M}");
int[] NumAmountArray = new int[M]; // задаем  массив длинной NumAmount

Console.WriteLine("Заполняем массив элементами");
int X = 0; // счетчик элементов > 0
for (int i=0; i<NumAmountArray.Length; i++){
    NumAmountArray[i] = int.Parse(Console.ReadLine()!);
        if (NumAmountArray[i] > 0){
            X++;
        }
}
Console.WriteLine($"[{String.Join(",",NumAmountArray)}]");  
Console.WriteLine($"Количество элементов больше нуля равно = {X}");  

}
 
*/

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*
Console.Clear();

int R =  new Random().Next(6, 10); // задаем рандомную длинну массива
Console.WriteLine($"Случайная длинна массива : {R}");

RandomArray ( R );


void RandomArray ( int RR){ // определяем метод 

int[] TheArray = new int[RR]; //  объявляем массив длинной R
Console.WriteLine("Заполняем массив случайными элементами от 0 до 100:");
for (int i=0; i< TheArray.Length; i++){
     TheArray[i] = new Random().Next(0, 100);
}
Console.WriteLine($"[{String.Join(",",TheArray)}]");
int temp;
for (int i=0; i < TheArray.Length-1; i++){
    for (int j = i+1; j < TheArray.Length; j++){
        if ( TheArray[i] > TheArray[j]){
            temp = TheArray[i];
            TheArray[i] = TheArray[j];
            TheArray[j] = temp;
        }
         
    }

}

Console.WriteLine("Вывод отсортированного массива");
Console.WriteLine($"[{String.Join(",",TheArray)}]");

 
}
 */
