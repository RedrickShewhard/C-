/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5" */

/* void PrintNumbers(int M, int N)
{
    Console.Write(M + " ");
    if (M > N)
    {
        PrintNumbers(M - 1, N);
    }
    else if (M < N)
    {
        PrintNumbers(M + 1, N);
    }
    else
    {
        return;
    }
}
PrintNumbers(8, 8); */



/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120 */

/* int sum = 0;
void rec(int m, int n)
{

    if (Math.Abs(m - n) == 0)
    {
        sum += m;
        return;
    }
    else if (m < n)
    {
        sum += m;
        m++;
    }
    else if (m > n)
    {
        sum += n;
        n++;
    }
    rec(m, n);
}
rec(-15, 1);
Console.WriteLine(sum); */


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

int rec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0)
    {
        return rec(m - 1, 1);
    } 
    else
    {
        return rec(m - 1, rec(m, n - 1));
    }
}

Console.Write(rec(2, 2)); 