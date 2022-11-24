
///////////////////////////////////______________________________/////////////////////////////////// 
///////////////////////////////////__________ЛЕКЦИЯ 3 C#_________/////////////////////////////////// 
///////////////////////////////////______________________________/////////////////////////////////// 

///////// Вид 1 группа методов ( - ничего не принимают ; -ничего не возвращают)
/*

void Method1() 
{
    Console.WriteLine( "Автор: ФИО "  ); // тело метода
}

Method1(); // так метод вызывается. скобки обязательно!!

*/

///////// Вид 2 группа методов ( - могут принимать аргументы ; -ничего не возвращают)

/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");
*/

/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // инкремент ( а уменьшение на 1у называют декриментом)
    }
}
// Method21(msg: "Текст", count: 4); // 4 раза увидеть текст. Если цикл зациклился нажать CTRL C 
Method21(count: 4, msg: "новый текст"); // если используем именованые методы, то порядок их вывода значения не имеет
*/


///////// Вид 3 группа методов ( - ничего не принимают аргументы ; -что-то возвращают)
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/


///////// Вид 4 группа методов ( - что-то принимают аргументы ; -что-то возвращают)
/*

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;

    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, " z ");
Console.WriteLine(res);

*/


///////// Цикл со счетчиком for

/*

string Method4(int count, string text)
{
    
    string result = String.Empty;
    for ( int i = 0 ; i < count; i++ )
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, " z ");
Console.WriteLine(res);

*/


///////// Цикл в цикле

/*
for (int i=2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

///////// Задача: Дан текст. В тексте нужно все пробелы заменить черточками,
///////// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
///////// маленькими “с”.
/*

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012 
// s[3] // r



string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length; 

    for (int i = 0; i < length; i++ )
    {
        if (text[i] == oldValue) result = result + $"{newValue}";

        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|' );
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

*/

///////// Задача:   в данной последовательности выбрать 1й элемент => и в оставшейся определить минимальный
/////////           поменять выделенный  элемент "6" с минимальным элементом местами
/////////           выбираем очередной раб элемент "8" а "1" уже не трогаем. Далее выбираем минимальный, поменять 
/////////           местами с рабочим и т.д. пока весь массив не будет отсортирован попорядку.

// Функции в программировании

// 1. Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы

/*

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // одинаковые элементы в массиве могут быть

// необходимо вывести на экран элементы массива.  несколько способов. 

void PrintArray ( int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();

}

void SelectionSort(int[] array)
{
    for (int i=0; i < array.Length - 1 ; i++ )
{
    int minPosition = i;
     
    for (int j= i + 1; j < array.Length; j++ ) // ищем макс элемент массива
    {
        if (array[j] < array[minPosition]) minPosition = j; // ищем макс элемент массива 
    }

    int temporary = array [i]; // обмен элементов
    array[i] = array[minPosition]; // обмен элементов
    array[minPosition] = temporary; // обмен элементов
}


}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

*/