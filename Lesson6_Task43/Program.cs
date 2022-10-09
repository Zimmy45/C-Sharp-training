Console.Clear();
Console.Write("Введите значение b1 - ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1 - ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 - ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 - ");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2)
    Console.Write("По ходу, прямые никогда не пересекутся");
else
    Console.Write($"Прямые пересекутся в точке с координатами ({(b2 - b1) / (k1 - k2)}; {k1 * (b2 - b1) / (k1 - k2) + b1}).");