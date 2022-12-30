Console.Clear();
int a = 1;
int [,] mas = new int[4, 4];
for (int j = 0; j < 3; j++)
    {
        mas[0, j] = a;
        a += 1;
    }
for (int i = 0; i < 3; i++)
    {
        mas[i, 3] = a;
        a += 1;
    }
a = 10;
for (int j = 0; j < 4; j++)
    {
        mas[3, j] = a;
        a = a - 1;
    }   
a = 12;
for (int i = 1; i < 3; i++)
    {
        mas[i, 0] = a;
        a = a - 1;
    }
a = 13;
for (int j = 1; j < 3; j++)
    {
        mas[1, j] = a;
        a = a + 1;
    }   
a = 16;
for (int j = 1; j < 3; j++)
    {
        mas[2, j] = a;
        a = a - 1;
    }
Console.WriteLine();
for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"{mas[i, j]} \t");
        }
        Console.WriteLine();
    }