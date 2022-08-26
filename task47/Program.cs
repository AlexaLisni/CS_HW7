// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
            
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j],4}.");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" ]");
    }
}

double[,] Saa(int size, int col)
{
double[,] array = new double[size, col];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =Math.Round( rand.Next(1, 10) + rand.NextDouble(), 1);
        }

}

return array;
}
Console.WriteLine("Введите клоличество строк");
int str = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите клоличество столбов");
int col = Convert.ToInt32(Console.ReadLine());

double[,] arr = Saa(str, col);
PrintMatrix(arr);

