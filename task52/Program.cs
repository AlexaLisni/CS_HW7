//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreatMatrixRundInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }

    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
            
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3},");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

void SumСol (int[,] matr)
{
    double sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)           
        {
            sum += matr[j,0];
        }
        sum = sum/matr.GetLength(1);
    Console.WriteLine(Math.Round(sum, 1));

}


int [,] martix = CreatMatrixRundInt(4, 4, 1 , 9);
PrintMatrix(martix);
SumСol(martix);