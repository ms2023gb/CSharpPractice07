/*
    52. Задайте двумерный массив из целых чисел.
    Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4

    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int rows = 3;
int columns = 4;
int minRandom = 1;
int maxRandom = 9;

int[,] mass = FillArrayRandomInt(rows, columns, minRandom, maxRandom);
Console.Clear();
const int tab = 6; // Константа для красоты печати таблицы
PrintArrayTable(mass);


double[] midColumns = MiddleColumns(mass);

PrintArray(midColumns);

int[,] FillArrayRandomInt(int rowsArray, int columnsArray, int min, int max)
{
    int[,] arrayRandom = new int[rowsArray, columnsArray];
    for (int i = 0; i < rowsArray; i++)
    {
        for (int j = 0; j < columnsArray; j++)
        {
            arrayRandom[i, j] = new Random().Next(min, max);
        }
    }
    return arrayRandom;
}

void PrintArrayTable(int[,] PrArray)
{
    int rows = PrArray.GetLength(0);
    int columns = PrArray.GetLength(1);
    Console.WriteLine($"{new string('-', columns * (tab + 2))}");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{PrArray[i, j],tab} |");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"{new string('-', columns * (tab + 2))}");
}

double[] MiddleColumns(int[,] array)
{
    rows = array.GetLength(0);
    columns = array.GetLength(1);
    double[] arrayMiddleColumns = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        arrayMiddleColumns[j] = Math.Round(sum / rows, 1); // Среднее округляем до десятых
    }
    return arrayMiddleColumns;
}

void PrintArray(double[] PrArray)
{
    columns = PrArray.Length;
    for (int i = 0; i < columns; i++)
    {
        Console.Write($"{PrArray[i],tab} |");
    }
    Console.Write($" - среднее арифметическое");
}
