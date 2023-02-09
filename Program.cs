// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.



double[,] CreateNumbersArray()
{
    Random rnd = new Random();
    double[,] array = new double[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rnd.NextDouble()* 100, 2);
        }
    }
    return array;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("|" + array[i, j] + "|\t");
        }
    }
    Console.WriteLine();
}

double[,] resultArray = CreateNumbersArray();
PrintArray(resultArray);