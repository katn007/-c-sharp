/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

//Решение на семинаре
/*
int a, b;
Console.Write("Введите 1 число ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите 2 число ");
int.TryParse(Console.ReadLine()!, out b);
if (a > b)
{
    Console.WriteLine($"Максимальное число = {a}");
}
else
{
    Console.WriteLine($"Максимальное число = {b}");
}*/



/*
int a = 5;
int b = 7;
int max = a;
if (a > b)
{
    Console.WriteLine($"Максимальное число = {max}");
}
else
{
    max = b;
}
Console.WriteLine($"Максимальное число = {max}");

int a = 2;
int b = 10;
int max = a;
if (a > b)
{
    Console.WriteLine($"Максимальное число = {max}");
}
else
{
    max = b;
}
Console.WriteLine($"Максимальное число = {max}");


int a = -9;
int b = -3;
int max = a;
if (a > b)
{
    Console.WriteLine($"Максимальное число = {max}");
}
else
{
    max = b;
}
Console.WriteLine($"Максимальное число = {max}"); 
*/

/* Задача 
 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 


int a = 2;
int b = 3;
int c = 7;
int max = a;

if (b > max) max = b;
if (c > max) max = c;


Console.WriteLine($"Максимум равен {max}");*/

/*
int a, b, c;
a = new Random().Next(10);
b = new Random().Next(10);
c = new Random().Next(10);
Console.Write($"{a} {b} {c} ");

int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;

Console.WriteLine($"Максимальное число = {max}");*/



/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */


/*int a;
Console.WriteLine("Введите число ");
int.TryParse(Console.ReadLine()!, out a);
if (a % 2 == 0)
{
    Console.WriteLine("это число четное");
}
else
{
    Console.WriteLine("это число НЕ четное");
}
*/




/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
/*int a;
Console.Write("Введите число ");
int.TryParse(Console.ReadLine(), out a);
int count = 2;
while (count <= a)
{
    Console.Write($"{count},");
    count += 2;
}
Console.WriteLine();*/

int a;
Console.Write("Введите число ");
int.TryParse(Console.ReadLine(), out a);
for (int i = 2; i <= a; i += 2)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();