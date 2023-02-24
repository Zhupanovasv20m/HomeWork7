// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Данная формула именно для  индекса
int rows = ReadInt("Введите номер строки: ");
int colums = ReadInt("Введите номер столбца: ");
int[,] matrix = new int[5, 6];
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);

if (rows < matrix.GetLength(0) && colums < matrix.GetLength(1)) Console.WriteLine(matrix[rows, colums]);
else Console.WriteLine($"{rows}, {colums} -> такого числа в массиве нет");

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 11);
        }
    }
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
