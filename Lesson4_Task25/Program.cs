Console.Clear();

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень его нужно возвести: ");
int b = Convert.ToInt32(Console.ReadLine());
int step = 1;
for (int i = 1; i <= b; i++)
{
    step = step * a;    
};
Console.WriteLine(step);