/*int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;


if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine($"Максимум равен {max}"); */

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