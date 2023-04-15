/*
    47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.

    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

Console.Clear();

int row = ReadNumberIntFromConsole("Введите количество строк: ");
int column = ReadNumberIntFromConsole("Введите количество столбцов: ");
int start = -9; // диапазон случайных чисел от
int finish = 9; // диапазон случайных чисел до
double[,] mass = FillArrayRandomDouble(row, column, start, finish);
PrintArray(mass);

int ReadNumberIntFromConsole(string message = "")
{
    if (message != "")
        Console.Write(message);
    string input = Console.ReadLine()!;
    return int.Parse(input);
}

double[,] FillArrayRandomDouble(int rowsArray, int columnsArray, int minRandom, int maxRandom)
{
    double[,] arrayRandom = new double[rowsArray, columnsArray];
    for (int i = 0; i < rowsArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            // заполняем массив сложением случайного числа в диапазоне + случайного числа от 0 до 1 и округляем до десятых
            arrayRandom[i, j] = Math.Round(new Random().Next(minRandom, maxRandom) + new Random().NextDouble(), 1);
        }
    }
    return arrayRandom;
}

void PrintArray(double[,] PrArray)
{
    for (int i = 0; i < PrArray.GetLength(0); i++)
    {
        for (int j = 0; j < PrArray.GetLength(1); j++)
        {
            Console.Write($"{PrArray[i, j],6}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
