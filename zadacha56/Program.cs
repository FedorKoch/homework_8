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

int SumOfElements(int[,] matrix)
{   
    int min = 0;
    int[] mas = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        mas[i] = sum;
    }
    for (int k = 0; k < matrix.GetLength(0) - 1; k++)
    {
    if (mas[k] > mas[k + 1]){
        min = k + 1 ;
    }
    }
 min += 1;
    return min; 
}
Console.Clear();
Console.Write("Введите размер прямоугольной матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while(size[0] == size[1])
{
    Console.WriteLine();
    Console.Write("Неверный размер матрицы");
    Console.WriteLine();
    Console.Write("Введите правильный размер прямоугольной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
int rez = SumOfElements(matrix);
Console.WriteLine();
Console.Write("Номер строки с наименьшей суммой элементов: ");
Console.Write(rez);
