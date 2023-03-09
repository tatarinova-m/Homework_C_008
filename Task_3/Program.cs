// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
int n1 = Convert.ToInt32(Console.ReadLine());

int m1 = n;
int[,] array = new int[m, n];
int[,] array2 = new int[m1, n1];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int[,] ar, int[,] ar2)
{
    int m2 = ar.GetLength(0);
    int n2 = ar2.GetLength(1);
    int[,] matrix = new int[m2, n2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < ar.GetLength(1); k++)
            {
                sum += ar[i, k] * ar2[k, j];
            }
            matrix[i, j] = sum;
        }
    }
    return matrix;
}

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}

FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
CreateMatrix(array, array2);
FillMatrix(CreateMatrix(array, array2));
