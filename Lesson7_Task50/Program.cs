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
Console.Write("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
InputMatrix(matrix);
Console.WriteLine();
Console.Write("Введите строку искомого элемента: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A > m)
{
    Console.WriteLine("Такой строки нет - Вы вышли за размеры массива.");
    return;
}
Console.Write("Введите столбец искомого элемента: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B > n)
{
    Console.WriteLine("Такого столбца нет - Вы вышли за размеры массива.");
    return;
}
Console.WriteLine();
Console.WriteLine($"Указанной позиции соответстсвует элемент массива {matrix[A - 1, B - 1]}.");