Console.Clear();
Console.Write("Введите пятизначное число число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a > 99999 || a < 1000)
{
    Console.Write("Число не похоже на пятизначное. Попробуйте еще раз: ");
    a = Convert.ToInt32(Console.ReadLine());
};

if (a / 10000 == a % 10 && a / 1000 % 10 == a % 100 / 10)

{
    Console.Write("Это палиндром");
}
else
    Console.Write("Нет, это не палиндром");