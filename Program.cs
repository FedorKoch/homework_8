﻿void InputMatrix(int[, ,] matrix)
{ 
    int chislo = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             for (int k = 0; k < matrix.GetLength(2); k++)
             {
            matrix[i, j, k] = chislo; 
            chislo += 1;
            Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры куба, укажите размер в диапазооне 4: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 90)
{
    Console.Write("размеры куба неверны, укажите размер в диапазооне 4: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[, ,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);