// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)         // Задаём массив
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-50, 51);
        Console.Write(matrix[i, j] + "\t");                // Для проверки выводим массив
    }
    Console.WriteLine();
}

double sum = 0;

for (int j = 0; j < matrix.GetLength(1); j++)           // Считаем среднее арифметическое для столбиков
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    sum = sum / matrix.GetLength(0);
    Console.WriteLine($"Среднее арифметическое {j + 1} столбика: {sum}");
    sum = 0;
}