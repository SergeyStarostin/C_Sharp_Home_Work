// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию 
// элементы каждой строки двумерного массива.

int rows = Prompt("Введите количество строк: ");
int cols = Prompt("Введите количество столбцов: ");
int [,] matrix = CreationMatrix(rows, cols);
FillArray(matrix); // Заполнение массива
PrintArray(matrix); // Вывод заполненного двумерного массива
System.Console.WriteLine();
System.Console.WriteLine("Отсортированный массив по убыванию:");
ArrangesElementsArrayRows(matrix); // Сортировка массива по убыванию
PrintArray(matrix); // Вывод на экран отсортированного массива

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
            array[i, j] = Convert.ToInt32(new Random().Next(1, 100));
        }
    }
}

void ArrangesElementsArrayRows (int [,] array)// Метод, для упорядочивания строк массива на убыванию
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] > array[i, k + 1]) // Поиск максимального значения массива
                {
                    int temporary = array[i, k + 1]; // Временная переменная
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temporary;
                }
            }
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