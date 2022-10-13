int[] array = { 1, 33, 23, 666, 7565, 33, 2323, 3, 23 };

int n = array.Length; // длина массива, кол-во элементов
int find = 23;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // Завершить цикл и выйти

    }
    index++;
}