// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет
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

void SearchElm(int[,] matrix)
{
    Console.WriteLine("Введите строку");
int str = Convert.ToInt32(Console.ReadLine())-1;

Console.WriteLine("Введите столб");
int col = Convert.ToInt32(Console.ReadLine())-1;

for(int i = 0; i < matrix.GetLength(0); i++) 
{
    if(col > matrix.GetLength(1) || str >matrix.GetLength(0)) Console.WriteLine("такого элемента в массиве нет");
    else if(i == str) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if(j == col)  Console.WriteLine($"строка:{str} столб:{col} елемент:{matrix[i,j]}");
        }
    } 
}

}

int [,] martix = CreatMatrixRundInt(4, 4, 1 , 9);
PrintMatrix(martix);
SearchElm(martix);