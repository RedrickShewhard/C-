/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь */


/* Console.WriteLine("Введите числа через запятую:");

string s = Console.ReadLine();
string[] nums = s.Split(",");
int summ = 0;
int[] mass = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
    mass[i] = int.Parse(nums[i]);
    if (mass[i] > 0)
    {
        summ += 1;
    } 
}
Console.WriteLine("Количество чисел больше ноля: " + summ); */


/*  Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * 
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
пользователем. */

Console.WriteLine("Enter b1");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter k1");
double k1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter b2");
double b2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter k2");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x) + b1;

Console.WriteLine($"{x}, {y}");
