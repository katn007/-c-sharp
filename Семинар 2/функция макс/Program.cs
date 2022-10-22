int[] array = { 8, 9, 11 };
int max = Max(array[0], array[1], array[2]);//
Console.Write($"Максимальное значение = {max} \n");
int Max(int _a, int _b, int _c)
{
    int max = _a;
    if (_b > max)
        max = _b;
    if (_c > max)
        max = _c;
    return max;
}

//Метод пузырьком//
/*int[] array = { 8, 9, 3, 10, 11 };
int[] array2 = { 8, 9, 3, 10, 11 };

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

Sort(array2);
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array2[i]} ");

void Sort(int[] _array)
{
    for (int j = 0; j < _array.Length - 1; j++)
    {
        for (int i = 0; i < _array.Length - 1; i++)
        {
            if (_array[i] > _array[i + 1])
            {
                int temp = _array[i];
                _array[i] = _array[i + 1];
                _array[i + 1] = temp;
            }
        }
    }
}*/