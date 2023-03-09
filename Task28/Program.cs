// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int rows = Prompt("Введите количество строк: ");
int cols = Prompt("Введите количество столбцов: ");
int [,] matrix = CreationMatrix(rows, cols);
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"{SumLineElements(matrix)+1} - строка с наименьшей суммой элементов");

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

int[,] CreationMatrix(int rows, int cols) // Метод создания двумерного массива
{
    int[,] array = new int[rows, cols];
    return array;
}

void FillArray(int[,] array) // Метод заполнения двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void PrintArray(int[,] array) // Метод вывода двумерного массива на экран 
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

int SumLineElements(int[,] array)
{
    int minSumElements = 0; 
    int lineNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumElement = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElement += array[i, j];
        }
        if (minSumElements == 0) minSumElements = sumElement;
        if (sumElement < minSumElements) lineNumber = i;  
    }
    return lineNumber;
}
