Console.Clear();
void InputMatrix(int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToInt32(new Random().Next(1, 10));
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
void OutputMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write(matrix[m, n] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов j: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j];
InputMatrix(matrix);
Console.WriteLine();
OutputMatrix(matrix);
