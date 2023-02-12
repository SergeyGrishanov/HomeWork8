// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] SortArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            if (numbers[i, j] < numbers[i, j + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = numbers[i, j];
                numbers[i, j] = numbers[i, j + 1];
                numbers[i, j + 1] = temp;
            }  
        }
    }
    return numbers;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

void Main()
{
    Console.Clear();

    Console.Write("Введите количество строк: ");
    int row = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов: ");
    int col = int.Parse(Console.ReadLine()!);

    int[,] ourArray = GetArray(row, col, 1, 10);
    PrintArray(ourArray);
    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями");
    SortArray(ourArray);
    PrintArray(ourArray);

}
Main();