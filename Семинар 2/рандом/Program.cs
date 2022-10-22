/*for (int i = 0; i < 100; i++)
{
    int a = new Random().Next(5, 20);
    Console.Write($"{a} ");

}
*/

/* Напишите программу, которая выводит случайное число из отрезка [10,99]
 и показывавет наибольшую цифру числа
 78 - 8 
 12 - 2
 85 - 8 

int rand = new Random().Next(10, 100);

Console.WriteLine(rand);
int a = rand / 10;
int b = rand % 10;
Console.Write($"Наибольшая цифра числа = \n");
if (a > b)
    Console.Write(a);
else
    Console.Write(b);*/

/* Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа
int rand = new Random().Next(100, 1000);
Console.WriteLine(rand);
Console.WriteLine($"{rand / 100 * 10 + rand % 10}");*/

//два числа а делим на б, делится или не делится - выводим остаток

/*int _a = new Random().Next(10, 100);
int _b = new Random().Next(10, 100);
int ost = 0;
Console.WriteLine($"{_a}");
Console.WriteLine($"{_b}");*/

/*int _a, _b;
Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine()!, result: out _a);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine()!, result: out _b);
if (_a % _b == 0)
    Console.WriteLine("Делится");
else
    Console.WriteLine($"Не Делится, остаток {_a % _b}");*/

int a;
Console.WriteLine("Введите  число");
int.TryParse(Console.ReadLine()!, result: out a);
if (a % 7 == 0 && a % 23 == 0)

    Console.WriteLine("Делится\n");

else
    Console.WriteLine("yt Делится");