/* Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
номер четверти плоскости, в которой находится эта 
точка.
 */

/* Console.WriteLine("Введите X:");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y:");
int Y = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты X:{X}, Y:{Y}");
if (X > 0 && Y > 0)
{
    Console.WriteLine(1);
} else if (X < 0 && Y > 0)
{
    Console.WriteLine(2);
} else if (X < 0 && Y < 0)
{
    Console.WriteLine(3);
} else if (X > 0 && Y < 0)
{
    Console.WriteLine(4);
} else 
{
    Console.WriteLine("Координаты не принадлежат четверти");
}  */


//_____________________________________________________________________________________________________

/*  Напишите программу, которая по 
заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y). */

/* Console.WriteLine("Введите номер четверти 1-4");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("Диапазон X от 0 до бесконечности, Диапазон Y от 0 до бесконечности");
}
else if (num == 2)
{
    Console.WriteLine("Диапазон X от 0 до минус бесконечности, Диапазон Y от 0 до бесконечности");
}
else if (num == 3)
{
    Console.WriteLine("Диапазон X от 0 до минус бесконечности, Диапазон Y от 0 до минус бесконечности");
}
else if (num ==4)
{
    Console.WriteLine("Диапазон X от 0 до бесконечности, Диапазон Y от 0 до минус бесконечности");
}
 */

//_________________________________________________________________________________________________________

/*  Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 2D 
пространстве. */

/* Console.WriteLine("Enter x1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(Math.Round (result, 2)); */

/* Напишите программу, которая 
принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N. */


/* Console.WriteLine("Enter number:");
int N = int.Parse(Console.ReadLine());
int i=1;
while (i<N)
{
    Console.Write(Math.Pow(i,2) + " ");
    i++;
} */
