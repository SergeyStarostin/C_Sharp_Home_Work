// Задача 4 * : Напишите программу, которая заполнит спирально квадратный массив.

// Пример: Введите размер двумерного массива = 4

// 0       11      10      9
// 1       16      15      8
// 2       13      14      7
// 3       4       5       6

int size = Prompt("Введите размер двумерного массива = ");
int[,] matrix = CreateMatrix(size, size);

PrintArray(FillSpiralMatrix(matrix));

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

int[,] CreateMatrix(int rows, int cols)// Метод создания двумерного массива
{
    int[,] array = new int[rows, cols];
    return array;
}

int[,] FillSpiralMatrix(int[,] matrix)  // Метод заполнения квадратного массива по спирали
{
    int element = 0;
    int i = 0;
    int j = 0;
    
    while (element <= matrix.Length)
    {
        matrix[i, j] = element;
        element++;
        if (j <= i + 1 && j + i < matrix.GetLength(0) - 1) i++;
        else if (j < i && j + i >= matrix.GetLength(1) - 1) j++;
        else if (j >= i && j + i > matrix.GetLength(0) - 1) i--;
        else j--;
    }
    return matrix;
}

void PrintArray(int[,] array) // Метод вывода двумерного массива на экран 
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