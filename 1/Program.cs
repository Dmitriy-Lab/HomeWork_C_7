// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [rows, columns];

for ( int i = 0; i < matrix.GetLength(0); i++ )    // matrix.GetLength(0) - длина строк
{
    for ( int j = 0; j < matrix.GetLength(1); j++ )    // matrix.GetLength(1) - считаем столбцы
    {
        matrix[i,j] = new Random().Next(-100, 101)+ new Random().NextDouble();      // Добавляем дробную часть к вещественным числам
        Console.Write(matrix[i,j]+"\t");        
    } 
Console.WriteLine();
}