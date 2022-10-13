/*int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//               0  1   2    3  4    5  6    7  8
int[] array = { 101, 52, 93, 74, 55, 65, 57, 85, 9 };
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(max);
*/






int[] array = { 4, 52, 93, 74, 55, 65, 57, 85, 898 };
int max = array[0];
int i = 1;
int n = array.Length;
while (i < n)
{
    if (array[i] > max) max = array[i];
    i++;
}
Console.WriteLine(max);
