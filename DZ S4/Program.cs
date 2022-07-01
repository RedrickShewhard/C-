/* Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B. */

/* Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральное число: ");
int b = int.Parse(Console.ReadLine());

if (b > 0)
{
    Console.WriteLine(Math.Pow(a, b));
}
else 
Console.WriteLine("Число не натрульное"); */



//____________________________________________________________
/* Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе. */

/* Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine());
int b = 0;
    while (a > 0)
    {
        b = b + a % 10;
        a = a /10 ;
    }
Console.WriteLine(b); */




//____________________________________________________________
/*  Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран. */


/* int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
 array[i] = new Random().Next(0,100);  
}
void PrintArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
{
    Console.Write(collection[i] + " ");
}
}
PrintArray(array); */