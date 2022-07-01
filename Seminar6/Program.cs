/* Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[10];

for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 10);
}
Print(mass);

int save;
for (int i = 0; i < mass.Length / 2; i++)
{
    save = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = save;
}
Print(mass); */

/* Напишите программу, которая принимает на вход три 
числа и проверяет, может ли существовать треугольник с сторонами 
такой длины. */

/* Console.WriteLine("Введите число x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число y: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число z: ");
int z = int.Parse(Console.ReadLine());

if ((x < (y + z)) && (y < (x + z)) && (z < (x + y)))
{
    Console.WriteLine("Является треугольником");
}
else
{
    Console.WriteLine("Не является треугольником");
} */

/* Напишите программу, которая будет преобразовывать 
десятичное число в двоичное. */

/* void Number(int a, int j)
{
    int[] A = new int[j];
    int index = 0;
    while (a > 0)
    {
        A[index] = a % 2;
        index++;
        a = a / 2;
    }
    for (int i = A.Length - 1; i >= 0; i--)
    {
        Console.Write($"{A[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int j = 0;
int p = number;
while (number > 0)
{
    number = number / 2;
    j++;
}

Number(p, j); */


//другой вариант решения

/* Console.WriteLine("Введите десятичное число: ");
int numb10 = int.Parse(Console.ReadLine());
int numb2;
string res = string.Empty;
string BinaryConverter(int numb10)
{
for (; numb10 > 0; numb10 = numb10 / 2)
{
numb2 = numb10 % 2;
res = numb2 + res;
}
return res;
}
Console.WriteLine(BinaryConverter(numb10));
 */

//________________________________________________________ 
/* Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1 */

/* void F(int n)
{
    int number1 = 0;
    int number2 = 1;
    int sup = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"F({i}) = {number1}");
        sup = number2;
        number2 = number2 + number1;
        number1 = sup;
    }
}
Console.WriteLine("Enter number");
int N = int.Parse(Console.ReadLine());
F(N); */

//______________________________________
/* Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного 
копирования. */

/* int Func(int c)
{
    c = new Random().Next(0, 100);
    return c;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] n = new int[10];
int[] N = new int[10];
for (int i = 0; i < n.Length; i++)
{
    n[i] = Func(n[i]);
}
Print(n);
Console.WriteLine();
for (int i = 0; i < n.Length; i++)
    N[i] = n[i];
Print(N);
int[] N3 = n;
Print(N3);
for (int i = 0; i < n.Length; i++)
{
    N[i] = 5;
    N3[i] = i;
    n[i] = i * i;
}
Print(n);
Print(N);
Print(N3); */