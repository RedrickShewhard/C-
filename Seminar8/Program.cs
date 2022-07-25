/* Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку 
массива. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 3, n = 4;
int[,] mass = new int[m, n];

int help = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}

Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(1); i++)
{
    help = mass[0, i];
    mass[0, i] = mass[mass.GetLength(0) - 1, i];
    mass[mass.GetLength(0) - 1, i] = help;
}

Print(mass); */

/* Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это 
невозможно, программа должна вывести сообщение для 
пользователя. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 4, n = 4;
int[,] mass = new int[m, n];

int help = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}

Print(mass);
Console.WriteLine();

if (mass.GetLength(0) != mass.GetLength(1))
{
    Console.WriteLine("Невозможно поменять местами");
} */

/* for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = i + 1; j < mass.GetLength(1); j++)
    {
        help = mass[i, j];
        mass[i, j] = mass[j, i];
        mass[j, i] = help;
    }

} */
//другой вариант решения
/* for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < i; j++)
    {
        help = mass[i, j];
        mass[i, j] = mass[j, i];
        mass[j, i] = help;
    }

}
Print(mass); */

/* Составить частотный словарь элементов 
двумерного массива. Частотный словарь содержит 
информацию о том, сколько раз встречается элемент 
входных данных. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}

Print(mass);
Console.WriteLine();

int[] array = new int[mass.Length];
int k = 0;
bool finded = false;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        finded = false;
        for (int l = 0; l < k; l++)
        {
            if (array[l] == mass[i, j])
            {
                finded = true;
                break;
            }
        }
        if (!finded)
        {
            array[k] = mass[i, j];
            k++;
        }


    }
}

for (int i = 0; i < k; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int t = 0; t < k; t++)
{
    int count = 0;
    int num = array[t];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] == num) count++;
        }
    }

    Console.WriteLine($"{num} встречается {count} раз");
} */

/* Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на 
пересечении которых расположен наименьший элемент 
массива. */

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int m = 4, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
    }
}

Print(mass);
Console.WriteLine();

int min = mass[0, 0];
int index1 = 0;
int index2 = 0;
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < min)
        {
            min = mass[i, j];
            index1 = i;
            index2 = j;
        }
    }
}
Console.WriteLine(min);

int[,] array = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (i != index1 && j != index2)
        {
            int k = i;
            if (i > index1) k = i - 1;
            int l = j;
            if (l > index2) l = j - 1;
            array[k, l] = mass[i, j];
        }
    }

}
Print(array);