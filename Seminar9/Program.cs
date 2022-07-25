//пример рекурсии
/* int rec(int n)
{
if (n == 0)
{
Console.WriteLine("Это конец рекурсии!");
return 1;
}

Console.WriteLine("Это рекурсия!");

return 2 * rec(n - 1);
}

Console.WriteLine("Результат рекурсии: " + rec(10)); */

/* Задача 63: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5" */

/* void PrintNumbers(int n)
{
    if (n == 0)
    {
        return;
    }
    PrintNumbers(n-1);
    Console.Write(n+ " ");
}

PrintNumbers(6); */

/* Задача 65: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" */

/* void PrintNumbers(int M, int N)
{
    if (M > N)
    {
        return;
    }
    Console.Write(M + " ");
    PrintNumbers(M + 1, N);
}
PrintNumbers(1, 5); */


/* Задача 67: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
453 -> 12 */

/* Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int rec(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n % 10 + rec(n / 10);
}

Console.WriteLine("Результат рекурсии: " + rec(n)); */

//_________________________________________________________________________
/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵) */

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
double rec(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Конец рекурсии");
        return 1;
    }
    if (b < 0)
    {
        return (1.0 / a) * rec(a, b + 1);
    }
    else
        return a * rec(a, b - 1);
}
Console.WriteLine("результат рекурсии: " + rec(a, b));
