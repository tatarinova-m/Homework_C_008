// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
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

int[,] FindMax(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {

        for (int j = 0; j < ar.GetLength(1); j++)
        {
            for (int k = 0; k < ar.GetLength(1) - 1; k++)
            {
                if (ar[i, k + 1] > ar[i, k])
                {
                    int t = ar[i, k];
                    ar[i, k] = ar[i, k + 1];
                    ar[i, k + 1] = t;
                }
            }

        }
    }
    return ar;
}


FillArray(array);
PrintArray(array);
Console.WriteLine();
FindMax(array);
PrintArray(array);