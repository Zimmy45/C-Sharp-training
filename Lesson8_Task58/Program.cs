Console.Clear();
Console.Write("Введите кол-во строк матрицы A: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы A: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во строк матрицы B: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы B: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (j != k)// проверка на возможность пересножения - согласованы ли матрицы
{
    Console.WriteLine("Матрицы не согласованы т.е. количество столбцов в первой не совпадает с количеством строк во второй матрице, поэтому перемножить их не получится.");
    return;
}
int[,] matrix1 = new int[i, j];
int[,] matrix2 = new int[k, l];
Console.WriteLine("Массив 1:");
InputMatrix(matrix1);
Console.WriteLine("Массив 2:");
InputMatrix(matrix2);
Console.WriteLine("Массив, полученный перемножением первых двух:");
int[,] matrix3 = new int[i, l];// размер результирующей матрицы - кол-во строк первой, кол-во столбцов второй

//int z = 0;
for (int m = 0; m < i; m++)
{
    int sum = 0;
    int z = 0;
    for (int n = 0; n < l; n++)
    {
        sum = sum + matrix1[m, n] * matrix2[n, m];
        matrix3[m, z] = sum;
        z = z+1;
    }
    Console.WriteLine(matrix3[m,z]);
    //matrix1[m, z] = sum;
    //Console.Write(matrix3[m, z] + " \t");
    //z = z + 1;
}
Console.WriteLine();

void InputMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = Convert.ToInt32(new Random().Next(1, 10));
            Console.Write(matrix[m, n] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}