/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
Console.Write("Введите M: ");
var m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
var n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
Random rnd = new ();

for (int i = 0; i < m; i++)
    for (int j = 0; j < n; j++)
        arr[i, j] = rnd.Next(-99, 99) + rnd.NextDouble(); // диапазон для красоты

Console.WriteLine("Массив MxN: ");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write(String.Format("{0,8:0.##}", arr[i, j]));
    Console.WriteLine();
}