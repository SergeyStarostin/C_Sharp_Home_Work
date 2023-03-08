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
            array[i, j] = Convert.ToInt32(new Random().Next(1, 15));
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

void PrintAverageResult(double[] array) // Метод вывода результата на экран
{  
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое элементов {i + 1} столбца = {array[i]}");
    }
}

double [] AverageCols(int[,] array) // Метод вычисления среднего арифметического каждого столбца
{
    double[] averageArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        averageArray[j] = result / array.GetLength(0);
    }
    return averageArray;
}

int rows = Prompt("Введите количество строк: ");
int cols = Prompt("Введите количество столбцов: ");
int [,] matrix = CreationMatrix(rows, cols);
FillArray(matrix); // Заполнение массива
PrintArray(matrix); // Вывод заполненного двумерного массива
double [] averageArray = AverageCols(matrix);
PrintAverageResult (averageArray); // Вывод результата на экран