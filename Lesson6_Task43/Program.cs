Console.Clear();
Console.Write("Введите значение b1 - ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1 - ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2 - ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2 - ");
int k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2)
    Console.Write("По ходу, прямые никогда не пересекутся");
else
    Console.Write($"Прямые пересекутся в точке с координатами [{(b2 - b1) / (k1 - k2)},{k1 * (b2 - b1) / (k1 - k2) + b1}].");