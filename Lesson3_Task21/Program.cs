Console.Clear();
Console.WriteLine("Введите координатs точки А: ");
int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координатs точки B: ");
int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());
int bz = Convert.ToInt32(Console.ReadLine());

double s = Math.Sqrt((ax - bx)*(ax - bx) + (ay - by)*(ay - by) + (az - bz)*(az - bz));

Console.Write(" => " + s);