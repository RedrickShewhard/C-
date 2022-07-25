/*  Задайте двумерный массив. Напишите программу, которая 
упорядочит по убыванию элементы каждой строки двумерного массива. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}

Print(mass);
Console.WriteLine();

int help = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < mass.GetLength(1) - 1 -j; k++)
        {
            if (mass[i, k] < mass[i, k+1])
            {
            help = mass[i, k];
            mass[i, k] = mass[i, k+1];
            mass[i, k+1] = help;
            }
        }
    }
}

Print(mass);
Console.WriteLine(); */


/* Задайте прямоугольный двумерный массив. Напишите 
программу, которая будет находить строку с наименьшей суммой элементов.
 */

/* 
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}
Print(mass);
Console.WriteLine();

int sum = 0;
int[] array = new int[m];
for (int i = 0; i < mass.GetLength(0); i++)
{
    int count = 0;
    int[] arr = new int[n];
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        count += mass[i, j];
        arr[j] = mass[i, j];
    }
    if (count > sum)
    {
        sum = count;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            array[j] = arr[j];
        }
    }
    
}

for (int j = 0; j < array.GetLength(0); j++)
    {
        Console.Write(array[j] + " ");
    }
 */


/*  Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц. */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}

int[,] mass2 = new int[m, n];

for (int i = 0; i < mass2.GetLength(0); i++)
{
    for (int j = 0; j < mass2.GetLength(1); j++)
    {
        mass2[i, j] = new Random().Next(1, 10);
    }
}
int[,] mass3 = new int[m, n];
for (int i = 0; i < mass3.GetLength(0); i++)
{
    for (int j = 0; j < mass3.GetLength(1); j++)
    {
        mass3[i, j] = mass[i, j] * mass2[i, j];
    }
}

Print(mass);
Console.WriteLine();
Print(mass2);
Console.WriteLine();
Print(mass3);
Console.WriteLine();