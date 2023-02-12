// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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
Console.WriteLine("Введите размер матриц: ");
int size = int.Parse(Console.ReadLine()!); // для простоты. матрицы делаем одинаковые
int[,] matrix1 = new int[size, size];
int[,] matrix2 = new int[size, size];
FillArrayRandom(matrix1);
FillArrayRandom(matrix2);
int[,] resultProduct = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            resultProduct[i, j] += (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц А * B");
PrintArray(resultProduct);
}
Main();