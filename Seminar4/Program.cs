/*  Напишите программу, которая 
принимает на вход число (А) и выдаёт сумму чисел 
от 1 до А. */
/* Console.WriteLine("Enter number: ");
int A = int.Parse(Console.ReadLine());
int sum = 0
for (int i = 1; i < A; i++)
{
    sum += i;
}
Console.WriteLine (sum); */

/* int Func(int num)
{
    int sum = 0;
    for (int i = 1; i < num; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine("Enter number: ");
int A = int.Parse(Console.ReadLine());
int n = Func(A);
Console.WriteLine(n); */

/*  Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе. */

/* Console.WriteLine("Enter number: ");
int A = int.Parse(Console.ReadLine());
count = 0
if (A == 0)
{
    Console.WriteLine ("1");
}
else
    {
    int count = 0;
    for ( ; A>0 ; A = A/10)
    {
        count ++;
    }
    Console.WriteLine("Number:" + count);
    } */


/* int Func(int A)
{
    int count = 0;
    for ( ; A>0 ; A = A/10)
    {
        count ++;
    }
    return count;
}
Console.WriteLine("Enter number: ");
int A = int.Parse(Console.ReadLine());
int n = Func (A);
if (A == 0)
{
    Console.WriteLine ("1");
}
else 
{
   Console.WriteLine (n);
}     */


//______________________________________________

/* Напишите программу, которая 
выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке. */

/* int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
 array[i] = new Random().Next(0,2);  
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
} */

int [] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
 array[i] = new Random().Next(0,2);  
}
void PrintArray (int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
{
    Console.Write(collection[i] + " ");
}
}
PrintArray(array);