// Используем методы заполнения массива случайными числами

void FillArray(int[] collection) // void значит этот метод ничего не возвращает
{
    int lenght = collection.Length;
    int index = 0;
    while( index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // функция по заполнению массива случайными числами
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]); // Функция по показу массива
        position++;
    }
}




int[] array = new int[10]; // по умолчанию в массиве будет 10 элементов

FillArray(array);
PrintArray(array);
