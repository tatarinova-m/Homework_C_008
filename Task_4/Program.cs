// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4, 4];

void FillArray(int[,] ar)
{
    ar[0, 0] = 1;
    for (int j = 1; j < ar.GetLength(1); j++)
    {
        ar[0, j] = ar[0, j - 1] + 1;
    }
    for (int i = 1; i < ar.GetLength(0); i++)
    {
        ar[i, 3] = ar[i - 1, 3] + 1;
    }
    for (int j = 2; j >= 0; j--)
    {
        ar[3, j] = ar[3, j + 1] + 1;
    }

    for (int i = 2; i > 0; i--)
    {
        ar[i, 0] = ar[i + 1, 0] + 1;
    }
    for (int j = 1; j < 3; j++)
    {
        ar[1, j] = ar[1, j - 1] + 1;
    }
    for (int i = 2; i < 3; i++)
    {
        ar[i, 2] = ar[i - 1, 2] + 1;
    }
    for (int j = 1; j > 0; j--)
    {
        ar[2, j] = ar[2, j + 1] + 1;
    }
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);