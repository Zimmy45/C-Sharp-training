Console.Clear();
int IsPrime(int N)
{
for (int i = 2; i < N; i++)
    {
        if (N % i == 0)
        {
            N = 0;
            break;
        }
    }
    return N;
}

int sum = 0;
Console.WriteLine("Введите три целых числа:");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (IsPrime(a) != 0) sum = sum + a;
if (IsPrime(b) != 0) sum = sum + b;
if (IsPrime(c) != 0) sum = sum + c;
Console.WriteLine(sum);
if(IsPrime(sum) == 0) Console.WriteLine("NO");
else Console.WriteLine("YES");
