Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
                for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToInt32(new Random().Next(-100, 101));
            Console.Write(matrix[i, j] + " \t");
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
for (int x = 0; x < j; x++)
    {
        double sum = 0;
        for (int y = 0; y < j; y++)
        {
            sum = sum + matrix[x, y];
            Console.WriteLine(sum+"\t");
        }

        Console.Write(sum / i + ";"+"\t");
    }