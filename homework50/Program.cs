/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
Console.WriteLine("Позиция элемента в массиве имеет формат [x,y]");
Console.Write("Введите x: ");
var x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
var y = Convert.ToInt32(Console.ReadLine());

int[,] arr = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.WriteLine("Распечатка массива: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
    Console.WriteLine();
}

if ((x >= arr.GetLength(0)) || (y >= arr.GetLength(1)) || (x < 0) || (y < 0))
{
    Console.WriteLine($"Элемента с позицией [{x},{y}] в массиве нет.");
    return;
}

Console.WriteLine($"Элемент с позицией [{x},{y}] имеет значение {arr[x,y]}.");