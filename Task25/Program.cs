// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

int Prompt (string message) // метод считывания чисел с консоли
{
    Console.Write(message);
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) // проверка условия корректности ввода
    {
        return value;
    }
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

void FillArray(int[,] array) // Метод заполнения массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] array) // Метод вывода массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

int indexRows = Prompt("Введите индекс строки: ");
int indexCols = Prompt("Введите индекс столбца: ");
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

if (indexRows < matrix.GetLength(0) && indexCols < matrix.GetLength(1)) 
{
    Console.WriteLine($"Элемент массива = {matrix[indexRows, indexCols]}");
}
else Console.WriteLine($"Такого элемента в массиве нет");