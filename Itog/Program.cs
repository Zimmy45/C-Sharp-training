Console.Clear();
Console.Write("Сколько элементов будет в исходном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[m];
string[] array2 = new string[m];
int count = 0;
for (int i = 0; i < m; i++)
{
    array1[i] = Console.ReadLine();
    if (array1[i].Length <= 3)
    {
        array2[count] = array1[i];
        count++;
    }
}
Console.WriteLine();
Console.Write("[ ");
for (int i = 0; i < count-1; i++)
{
        Console.Write(array2[i] + ", ");
}
Console.Write(array2[count-1]);
Console.Write(" ]");