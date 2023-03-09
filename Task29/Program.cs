//Задача 3 * : Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Введите количество строк: 3
// Введите количество столбцов: 4

// 20      6       7       1
// 43      31      46      9
// 39      6       34      40

// 47      2       4       13
// 26      8       7       33
// 9       25      43      48

// 940     12      28      13
// 1118    248     322     297
// 351     150     1462    1920

int rows = Prompt("Введите количество строк: ");
int cols = Prompt("Введите количество столбцов: ");

int [,] firstArray = new int[rows, cols];
int [,] secondArray = new int[rows, cols];
int [,] resultArray = new int[rows, cols];

FillArray(firstArray);
PrintArray(firstArray);

FillArray(secondArray);
PrintArray(secondArray);

int [,] matrixProd = MatrixProduct(resultArray);
PrintArray(matrixProd);

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
            array[i, j] = Convert.ToInt32(new Random().Next(1, 20));
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

int [,] MatrixProduct(int[,] array) // Метод умножения двумерных массивов
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i, j] = firstArray[i, j] * secondArray[i, j];
            }
        }
    }
    return array;
}