Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

string? l = Convert.ToString(a);

for (int i = 1; i <= l.Length; i++)
{
    sum = sum + a % 10;
    a = a / 10;     
};
Console.WriteLine(sum);