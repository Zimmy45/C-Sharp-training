Console.Write("Введите день недели: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 7)
Console.WriteLine("Нет столько дней в неделе. Попробуйте еще раз.");
else if (x == 6 || x == 7)
{
    Console.WriteLine("Это выходной");
}
else
Console.WriteLine("Это не выходной");
