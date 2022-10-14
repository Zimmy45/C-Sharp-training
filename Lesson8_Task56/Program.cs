Console.Clear();
Console.Write("Введите кол-во строк i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов j: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j];
int minSum = 0;
int row = 1;
for (int m = 0; m < matrix.GetLength(0); m++)
{
    int sum = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {
        matrix[m, n] = Convert.ToInt32(new Random().Next(1, 10));
        Console.Write(matrix[m, n] + " \t");
        sum = sum + matrix[m, n]; // суммирую элементы строки
        if (m == 0 && n == matrix.GetLength(1)-1) minSum = sum;// присваиваю переменной minSum сумму эл-тов первой строки
    }
        //Console.Write($"||{sum}"); вывод суммы по строке
        if (sum < minSum)
    {
        minSum = sum;
        row = m+1;//запоминаю строку
    }
Console.WriteLine();        
}
 Console.WriteLine();
Console.WriteLine($"{row} строка");