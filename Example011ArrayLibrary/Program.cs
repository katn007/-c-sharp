void FillArray(int[] collection)// FillArray и collection - названия
{
    int lenght = collection.Length; //Длина массива "collection"
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 50);
        index++;
    }
}


void PrintArray(int[] col) // методы (функции)- не возращает значения, не нужен ретерн
{
    int count = col.Length; // длина массива "col"
    int position = 0; // position вместо index
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[20];// по умолчанию заполняется нулями

FillArray(array);
PrintArray(array);