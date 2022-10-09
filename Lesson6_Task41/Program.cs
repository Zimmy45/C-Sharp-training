Console.Clear();
Console.Write("Сколько чисел будем вводить? ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 1; i <= M; i++)
{
Console.Write("число " + i + " = ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0) count = count + 1;
};
Console.WriteLine($"Вы ввели {count} чисел больше 0.");

// Хотел еще с учетом падежей выводить, но что-то не получилось
// if (count == 1 || (count % 10 == 1 & count =! 11))
// Console.WriteLine($"Вы ввели {count} число больше 0.");
// else if (2 <= count <= 4 || 2 <= count % 10 <= 4) 
// Console.WriteLine($"Вы ввели {count} числа больше 0.");
// else Console.WriteLine($"Вы ввели {count} чисел больше 0.");