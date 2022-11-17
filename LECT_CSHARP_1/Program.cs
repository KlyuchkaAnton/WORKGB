
// Пример 1.01
/*
Console.WriteLine("Введите Ваше имя ");

string username = Console.ReadLine();

Console.WriteLine("Привет, ");

Console.WriteLine(username);
*/


// Пример 1.02
/*
int numberA = 31;
int numberВ = 5;
int result = numberA + numberВ;
Console.WriteLine(result);
*/


// Пример 1.03
/*
double numberA = 12;
double numberВ = 5;
double result = numberA / numberВ;
Console.WriteLine(result);
*/


// Пример 1.03
/*
int numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
*/


// Пример 1.04
/*
Console.WriteLine("Введите имя пользователя ");
 
string username = Console.ReadLine();

if ( username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша! ");
}
else
{
    Console.WriteLine("Привет ");
    Console.WriteLine(username);
}
*/

// Пример 1.05
/*
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;
int max = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;
Console.Write("max = ");
Console.WriteLine(max);
*/


// Пример 1.06
/*
Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");
int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int x3 = 80;
int y3 = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    
if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    } 

 if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    } 

 if (what == 2)
    {
        x = (x+x3)/2;
        y = (y+y3)/2;
    } 

Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++; //count = count + 1;

} 
*/
