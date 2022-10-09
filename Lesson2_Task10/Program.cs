Console.Write("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100 || x > 999)
Console.WriteLine("Вы уверены, что оно трехзначное? Попробуйте еще раз.");
else
{
    int y = (x % 100) / 10;
    Console.WriteLine("Вторая цифра - " + y);
}