// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt (string message) // Метод считывания чисел с консоли
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

void FillArray(int[,] array) // Метод заполнения двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 15));
        }
    }
}

void PrintArray(int[,] array) // Метод вывода на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t"); // выравнивание столбцов
        }
    }
    Console.WriteLine();
}

void AverageCols(int[,] array) // Метод вычисления среднего арифметического каждого столбца
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое элементов {j + 1} столбца = {result / array.GetLength(0)} ");
    }
}

int rows = Prompt("Введите количество строк:  ");
int cols = Prompt("Введите количество столбцов: ");
int[,] matrix = new int[rows, cols];
FillArray(matrix);
PrintArray(matrix);
AverageCols(matrix);