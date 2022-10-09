Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) count = count +1;
}
Console.WriteLine("[" + string.Join(" | ", array) + "]");
Console.WriteLine($"Количество четных элементов в массиве - {count}.");