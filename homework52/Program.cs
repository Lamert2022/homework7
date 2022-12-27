/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] arr = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
var dim0 = arr.GetLength(0);
var dim1 = arr.GetLength(1);

int[] colSums = new int[dim1];

for (int i = 0; i < dim0; i++)
{
    for (int j = 0; j < dim1; j++)
        colSums[j] += arr[i,j];
}

Console.WriteLine("Распечатка массива: ");
for (int i = 0; i < dim0; i++)
{
    for (int j = 0; j < dim1; j++)
        Console.Write(String.Format("{0,5:0.#}", arr[i, j]));
    Console.WriteLine();
}

for (int i = 0; i < dim1; i++)
    Console.Write("-----");
Console.WriteLine();

for (int i = 0; i < dim1; i++)
    Console.Write(String.Format("{0,5:0.##}", (double)colSums[i] / dim0));
Console.Write(" <= среднее арифмитическое для столбца");
Console.WriteLine();
Console.WriteLine();