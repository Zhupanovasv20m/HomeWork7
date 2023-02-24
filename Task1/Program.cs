// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
System.Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m, n];
for (int i = 0; i< matrix.GetLength(0); i++)
{
    for (int j = 0; j< matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    System.Console.WriteLine();
}


void PrintArray (int [,] matr)
{
for (int i = 0; i< matr.GetLength(0); i++)
{
    for (int j = 0; j< matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i, j]} ");
    }
    System.Console.WriteLine();
}
}

void FillArray (int [,] matr)
{
for (int i = 0; i< matr.GetLength(0); i++)
{
    for (int j = 0; j< matr.GetLength(1); j++)
    {
       matr [i, j] = new Random().Next(1, 11);
    }
    System.Console.WriteLine();
}
}

PrintArray (matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray (matrix);
