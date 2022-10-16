Console.Clear();
void InputMatrix(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[x, y, z] = Convert.ToInt32(new Random().Next(10, 100));
                Console.Write(matrix[x, y, z] + " (" + x + "," + y + "," + z + ")" + " \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Console.Write("Введите размер матрицы X: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер матрицы Y: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер матрицы Z: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[i, j, k];
Console.WriteLine();
InputMatrix(matrix);


