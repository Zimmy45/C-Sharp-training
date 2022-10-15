Console.Clear();
Console.Write("Введите кол-во строк первой матрицы (оно же - количество столбцов второй матрицы): ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы (оно же - количество строк второй матрицы): ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[i, j];
int[,] matrix2 = new int[j, i];
Console.WriteLine("Массив 1:");
InputMatrix(matrix1);
Console.WriteLine("Массив 2:");
InputMatrix(matrix2);
Console.WriteLine("Массив, полученный перемножением первых двух:");
int[,] matrix3 = new int[i, j];
for (int m = 0; m < matrix1.GetLength(0); m++)
{
    int sum = 0;
    for (int n = 0; n < matrix1.GetLength(1); n++)
    {
        matrix3[m, n] = sum + matrix1[m,n]*matrix2[n,m];
        Console.Write(matrix3[m, n] + " \t");               
    }
Console.WriteLine();        
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