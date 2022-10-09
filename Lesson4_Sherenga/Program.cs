Console.Clear();
Console.Write("Сколько учеников в Петином классе (не считая Петю)? ");
int N = Convert.ToInt32(Console.ReadLine());
int[] A = new int[N];
Console.WriteLine("Введите рост учеников:");
for (int i = 0; i < A.Length; i++)
    {
        Console.Write($"ученик {i+1}: ");
    A[i] = Convert.ToInt32(Console.ReadLine());
    }

Console.Write("Какой рост Пети? ");
int X = Convert.ToInt32(Console.ReadLine());
// Перебираем шеренгу и сравниваем с Петей
int pos = 0;
for (int i = 0; i < A.Length; i++)
    {
        if (X <= A[i]) pos = i+1;
    }
Console.WriteLine($"Петя должен занять {pos+1}-ую позицию.");
// Хотел вывести массив, подменив в нем рост Пети его именем
// но не нашел как заменить целочисленное значение строковой величиной.
// Это можно как-нибудь реализовать типа:
// A[pos] = string "Петя";
// Console.WriteLine("[ " + string.Join(" | ", A) + " ]");