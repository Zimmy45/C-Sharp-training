Console.Clear();
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            matrix[i, j] = Convert.ToInt32(new Random().Next(1, 10));
            Console.Write(matrix[i, j] + " \t");
            sum = sum + matrix[i, j];
        }
        matrix[i, j+1] = sum;
        Console.WriteLine();
    }
}


Console.Write("Введите кол-во строк i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов j: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j+1];
InputMatrix(matrix);
Console.WriteLine();

