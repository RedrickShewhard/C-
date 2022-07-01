/* Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно 
палиндромом. */

/* Console.WriteLine("Enter 5-digit number");
String s = Console.ReadLine();
Console.WriteLine (s);
String s1 = s.Substring (0, 2);
String s2 = s.Substring (3, 2);
String output = new String(s2.ToCharArray().Reverse().ToArray());
if (s1 == output)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine ("No");
} */

//второй способ решения
/* Console.WriteLine("Enter 5-digit number");
int x = int.Parse(Console.ReadLine());
int a = x % 100;
int b = x / 1000;
int b1 = b / 10;
int b2 = b % 10;
int b3 = (b2 * 10 + b1);
if (a == b3)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine ("No");
} */



//______________________________________________________________________________________________
/*  Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между 
ними в 3D пространстве. */

/* Console.WriteLine("Enter x1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z2");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1-z2, 2));
Console.WriteLine(Math.Round (result, 2)); */


//______________________________________________________________________________________________
/* Напишите программу, которая принимает на 
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125 */

/* Console.WriteLine("Enter number:");
int N = int.Parse(Console.ReadLine());
int i=1;
while (i<N)
{
    Console.Write(Math.Pow(i,3) + " ");
    i++;
} */