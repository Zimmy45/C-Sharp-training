static uint A(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
        if (m != 0 && n == 0)
        return A(n - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}
Console.Clear();
Console.Write("Введите 1-ое число: ");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine(A(m, n));
