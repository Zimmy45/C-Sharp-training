Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" => ");
for (int i = 1; i <= n; i++)
{
   if (i == n)
   Console.Write(i * i * i);
   else
   Console.Write(i * i * i + ", ");
};