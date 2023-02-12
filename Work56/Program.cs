// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов

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
void MinSumElements(int[,] matrix)
{
    int indexLine = 0;
    int minSum = Int32.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];        
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexLine++;
        }
    }
    Console.WriteLine("Минимальная сумма находится в строке под номером: " + (indexLine));
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

Console.Clear();

int[,] array = GetArray(m: 3, n: 4, minValue: 1, maxValue: 10);
PrintArray(array);
Console.WriteLine();

MinSumElements(array);
Console.WriteLine();