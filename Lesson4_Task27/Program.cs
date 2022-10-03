Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (x > 0)
    {
        sum = sum + x % 10;
        x = x / 10;
    }
Console.WriteLine($"Сумма цифр равна {sum}");