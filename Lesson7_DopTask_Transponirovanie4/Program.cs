Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 101);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }

}


Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
InputMatrix(matrix);
string sep = Convert.ToString("--"+"\t");
Console.WriteLine(string.Concat(Enumerable.Repeat(sep, n)));
int[,] matrixResult = new int[m, n];
for (int i = 0; i < matrixResult.GetLength(0); i++)
{
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
        matrixResult[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
        Console.Write(matrixResult[i, j] + " \t");
    }
    Console.WriteLine();
}
