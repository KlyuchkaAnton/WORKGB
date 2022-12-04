 // https://c-sharp.pro/s1-%d0%bf%d1%80%d0%be%d1%81%d1%82%d0%b5%d0%b9%d1%88%d0%b8%d0%b5-%d0%bf%d1%80%d0%be%d0%b3%d1%80%d0%b0%d0%bc%d0%bc%d1%8b-%d0%b0%d1%80%d0%b8%d1%84%d0%bc%d0%b5%d1%82%d0%b8%d1%87%d0%b5%d1%81%d0%ba%d0%b8/
 
 //S1.1.Вывести на экран число с точностью до сотых.

Console.WriteLine("//S1.1.Вывести на экран число с точностью до сотых.");

Random x = new Random();

double y = x.NextDouble();

Console.WriteLine($"Оригинальное число {y}");

Console.WriteLine($"Число после округления {Math.Round(y, 2)} ");



