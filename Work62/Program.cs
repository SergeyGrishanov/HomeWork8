// Заполните спирально массив 4 на 4.
Console.Clear();

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);

int[,] numbers = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    numbers[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}