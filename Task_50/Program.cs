/*
    50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    и возвращает значение этого элемента или же указание, что такого элемента нет.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    1, 7 - >такого числа в массиве нет
*/

int rows = 3;
int columns = 4;
int minRandom = -9;
int maxRandom = 9;

int[,] mass = FillArrayRandomInt(rows, columns, minRandom, maxRandom);
Console.Clear();
PrintArray(mass);

int inputRow = ReadNumberIntFromConsole("Введите номер строки: ");
int inputColumn = ReadNumberIntFromConsole("Введите номер столбца: ");
if (inputRow > rows || inputColumn > columns) Console.WriteLine("Нет такого числа в массиве");
else Console.WriteLine($"Это число: {mass[inputRow - 1, inputColumn - 1]}");

int ReadNumberIntFromConsole(string message = "")
{
    if (message != "")
        Console.Write(message);
    string input = Console.ReadLine()!;
    return int.Parse(input);
}

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

void PrintArray(int[,] PrArray)
{
    for (int i = 0; i < PrArray.GetLength(0); i++)
    {
        for (int j = 0; j < PrArray.GetLength(1); j++)
        {
            Console.Write($"{PrArray[i, j],4}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
