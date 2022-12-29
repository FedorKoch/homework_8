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
void SortingMas(int[,] matrix)
{
    for ( int i = 0; i < matrix.GetLength(0); i++)
    {
       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
            if (matrix[i, k] < matrix[i, k + 1]){
            int temp = matrix[i, k + 1];
            matrix[i, k + 1] = matrix[i, k];
            matrix[i, k] = temp; 
            }
            }
            
        }
    }
}
void Print(int[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
SortingMas(matrix);
Print(matrix);