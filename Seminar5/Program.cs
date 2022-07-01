/* Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна 
-20 */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
    Console.WriteLine();
}

int[] mass = new int[12];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
}
Console.WriteLine();

Print(mass);

int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        sumPos += mass[i];
    }
    else
    {
        sumNeg += mass[i];
    }
}

Console.WriteLine("Положительные: " + sumPos);
Console.WriteLine("Отрицательные: " + sumNeg); */


//______________________________________________________
/* Напишите программу замена элементов 
массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот. */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
    Console.WriteLine();
}

int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

Print(array);
 for (int i = 0; i < array.Length; i++)
 {
     array[i] *= -1;
 }

 Print(array); */

//_______________________________________________________

/*   Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве. */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}

Print(array);

bool Exist = false;

Console.WriteLine("Enter number:");
int A = int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == A)
    {
        Exist = true;
        break;
    }
}
if (Exist)
{
    Console.WriteLine("Yes");
}
else Console.WriteLine("No");
 */

//_______________________________________________

/*  Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99].  */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 200);
}

Print(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine($"Число элементов массива в отрезке [10,99]: {count}"); */




//______________________________________________________
/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве. */



void Print(int[] array)
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
    array[i] = new Random().Next(0, 10);
}

Print(array);

int[] mass = new int[(1 + array.Length) / 2];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = array[i] * array[array.Length - i - 1];
}


Print(mass);