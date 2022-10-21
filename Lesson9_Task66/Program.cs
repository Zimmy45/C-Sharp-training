string Print(int m, int n, int sum)
{

    if (n == m)
        return $"{sum + m} ";
    return Print(m+1, n, sum + m);
}
Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine(Print(Math.Min(n, m), Math.Max(n, m), sum));
