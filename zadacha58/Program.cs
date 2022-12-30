void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-20, 21); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int [,] Multiplication(int[,] matrix, int[,] matrix2)
{
    int [,] mas = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            mas[i,j] = matrix[i,j] * matrix2[i,j];
        }
    }
    return mas;
}

Console.Clear();
Console.Write("Введите размеры  матриц: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
InputMatrix(matrix2);
int [,] result = Multiplication(matrix, matrix2);
Console.WriteLine();
Console.Write("Результирующая матрица: ");
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{result[i, j]} \t");
        }
        Console.WriteLine();
    }
}

