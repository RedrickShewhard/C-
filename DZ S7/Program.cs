/* Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. */

/* void Print(double[,] arr)
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

int m = 3, n = 4;
double[,] mass = new double[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        mass[i, j] = Math.Round(mass[i, j], 2);
    }
}

Print(mass); */

//__________________________________________________

/* Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет. */

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
int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j;
    }
}

Console.WriteLine("Введите номер строки: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int b = int.Parse(Console.ReadLine());


if ((a >= 0 && a < m) && (b >= 0 && b < n))
{
    Console.WriteLine("Значение элемента: " + mass[a, b]);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Такого элемента нет");
    Console.WriteLine();
}

Print(mass); */


//____________________________________________________
/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом 
столбце. */

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
        mass[i, j] = i + j;
    }
}
for (int j = 0; j < mass.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum = sum + Convert.ToDouble(mass[i, j]);
    }
    Console.WriteLine(sum / Convert.ToDouble(mass.GetLength(0)));
}
Console.WriteLine();
Print(mass);