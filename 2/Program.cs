// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

int rowsMax = new Random().Next(1, 10);
int columnsMax = new Random().Next(1, 10);

Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rowsMax, columnsMax];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 101);
        Console.Write(matrix[i, j] + "\t");                // Для проверки выводим массив
    }
    Console.WriteLine();
}

if (row <= matrix.GetLength(0) && column <= matrix.GetLength(1))
{
    Console.WriteLine("Значение элемента: " + matrix[row - 1, column - 1]);
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}