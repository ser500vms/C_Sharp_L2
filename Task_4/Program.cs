// Нахождение элемента массива равного заданному пользователем числу из одномерного массива.

int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

int n = array.Length;
int find = 4;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // это значит прирви если нашел ближайшее число
    }
    index++;
}