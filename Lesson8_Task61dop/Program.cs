Console.Clear();
Console.Write("Введите количество строк в треугольнике Паскаля: ");// я вершину тоже считал за первую строку, хотя по картинке - она нулевая 
int h = Convert.ToInt32(Console.ReadLine());
int s = h * 2 + 1;//ширина основания матрицы
int[,] matrix = new int[h, s];//матрица на столбец шире справа и слева, по умолчанию заполнена нулями
matrix[0, h] = 1; // помещаю единицу в вершине - в центре нулевой строки матрицы
for (int i = 1; i < h; i++)// отталкиваясь от нулевой строки заполняюю последующие
{
    for (int j = 1; j < s - 1; j++)
    {
        matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
    }
}
Console.WriteLine();
for (int i = 0; i < h; i++)//вывожу матрицу на экран, заменяя нули пустыми строками
{
    for (int j = 0; j < s; j++)
    {
        if (matrix[i, j] == 0) Console.Write("" + "\t");
        else Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}