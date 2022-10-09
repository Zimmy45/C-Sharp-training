Console.Clear();
Console.Write("Сколько будет чисел? - ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int max = 0;
int i = 0;

//цикл для генерирования элементов массива и определения максимального
for (i = 0; i < n; i++)
    {
    array[i] = Convert.ToInt32(new Random().Next(0, 101));
    if (array[i] > max) max = array[i];
    }
Console.WriteLine("[ " + string.Join(" | ", array) + " ]");

//цикл для обнуления первого найденного макимального
for (i = 0; i < n; i++)
{
if (array[i] == max) array[i] = 0;
}
max = 0;
//цикл для повторного нахождения максимального 
for (i = 0; i < n; i++)
    {
        if (array[i] > max) max = array[i];
    }
Console.WriteLine("Второе по величине число из сгенерированных - это число " + max);