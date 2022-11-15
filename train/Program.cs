// task 67


int Print(int A, int B)
{
   if (B == 0)
      return 1;
   return Print(A, B - 1)*A;
}


Console.Clear();
Console.Write("Введите число A: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Print(A,B));
