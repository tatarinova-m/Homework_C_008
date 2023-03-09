
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] FindMin(int[,] num)
{
    int[] number = new int[num.GetLength(0)];

    for (int i = 0; i < num.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < num.GetLength(1); j++)
        {
            sum += num[i, j];
        }
        number[i] = sum;
    }
    return number;
}


void CompareMin(int[] ar)
{
    int min = ar[0];
    int minIndex = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] < min)
        {
            min = ar[i];
            minIndex = i;
        }

    }
    Console.Write($"Строка с наименьшей суммой({min}) - {minIndex} ");
}



FillArray(array);
PrintArray(array);
Console.WriteLine();
CompareMin(FindMin(array));

