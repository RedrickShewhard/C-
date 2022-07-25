// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт 
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18


// int Fibbonacci(int item1, int item2, int number)
// {
// if (number < 1) return 0;
// if (number == 1) return item1;
// if (number == 2) return item2;
// return Fibbonacci(item1, item2, number - 1) + Fibbonacci(item1, item2, number - 2);
// }

// int N = 5;
// for (int i = 1; i <= N; i++)
// {
// Console.Write(Fibbonacci(3, 4, i) + " ");
// }

// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» 
// и «в». Покажите все слова, состоящие из n букв, которые можно построить из 
// букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са

// string[] Words(string alpha, int length)
// {
// string[] result;
// if (length <= 0)
// {
// result = new string[1];
// result[0] = String.Empty;
// return result;
// }

// string[] resultOld = Words(alpha, length - 1);


// result = new string[resultOld.Length * alpha.Length];
// int count = 0;
// for (int i = 0; i < resultOld.Length; i++)
// {
// for (int j = 0; j < alpha.Length; j++)
// {
// result[count] = resultOld[i] + alpha[j];
// count++;
// }
// }

// return result;
// }


// int n = 2;
// string alphabet = "абвгде";
// string[] word;
// word = Words(alphabet, n);

// for (int i = 0; i < word.Length; i++)
// {
// Console.Write((i + 1) + " " + word[i] + " ");
// }

// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные 
// представления нескольких чисел (без разделителя). В массиве data хранится 
// информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел 
// массива data с учётом информации из массива info.
// 25 мин
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int sum = 0;
int mult;
for (int i = 0; i < info.Length; i++)
{
mult = 0;
for (int j = sum; j < sum + info[i]; j++)
{
mult += data[j] * (int)Math.Pow(2, info[i] - j + sum - 1);
Console.WriteLine("Степень: " + (info[i] - j + sum - 1));
}
sum += info[i];
Console.WriteLine(mult);
}
