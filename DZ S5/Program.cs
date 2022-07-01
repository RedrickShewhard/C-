/*  Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в 
массиве. */

/* void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}

int[] array = new int[9];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

Print(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count ++;
    }
}
Console.WriteLine(count); */




//____________________________________________________
/* Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях. */

/* void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}

int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}

Print(array);

int count = 0;
for (int i = 0; i < array.Length; i+=2)
{
    count += array [i];
}
Console.WriteLine(count); */


//____________________________________________________
/* Задайте массив вещественных чисел. Найдите 
разницу между максимальным и минимальным 
элементов массива. */

/* void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] array = new double[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble(), 2);
}

Print(array);
double min = array[0];
double max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine(max - min); */
