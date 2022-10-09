Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    if (i % 2 != 0) sum = sum + array[i];
}
Console.WriteLine("[ " + string.Join(" | ", array) + " ]");
Console.WriteLine($"Сумма элементов на нечетных позициях в массиве равна {sum}.");