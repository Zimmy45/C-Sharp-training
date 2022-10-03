Console.Write("Введите число: ");
string x = Convert.ToString(Console.ReadLine());

if (x.Length < 3)
Console.WriteLine("Нет третьей цифры");
else
{
    Console.WriteLine("Третья цифра - " + x[2]);
}
