// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Введите размер массива(x)");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива(y)");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива(z)");
int z = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x * y * z];

int[] FillRandomNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

int[] SortArray(int[] ar)
{
    for (int i = 0; i < ar.Length - 1; i++)
    {
        for (int j = 0; j < ar.Length; j++)
        {
            if (ar[i] > ar[i + 1])
            {
                int temp = ar[i + 1];
                ar[i + 1] = ar[i];
                ar[i] = temp;
            }
        }
        if (ar[i] == ar[i + 1])
        {
            ar[i + 1] = new Random().Next(10, 100);
        }
    }


    return ar;
}


int[,,] CreateArray(int[] arr)
{
    int[,,] ar = new int[x, y, z];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            for (int k = 0; k < ar.GetLength(2); k++)
            {
                for (int l = 0; l < arr.Length; l++)
                {
                    ar[x, y, z] = arr[l];
                }

            }
        }

    }
    return ar;
}

int[,,] PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{arr[i, j, k]} ({i} , {j} , {k})");
            }
        }
    }
    return arr;
}

FillRandomNum(array);
SortArray(FillRandomNum(array));
CreateArray(FillRandomNum(array));
PrintArray(CreateArray(FillRandomNum(array)));

