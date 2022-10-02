Console.Clear();

int[] array = new int[8];

int i = 0;

for (i = 0; i < array.Length; i++)
    {
    array[i] = Convert.ToInt32(Console.ReadLine());
    
    }
Console.WriteLine("[ " + string.Join(" | ", array) + " ]");