//Задача 3 * : Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows1 = Prompt("Введите количество строк перой матрицы: ");
int cols1 = Prompt("Введите количество столбцов первой матрицы: ");
int [,] firstArray = new int[rows1, cols1];
FillArray(firstArray);
PrintArray(firstArray);

int rows2 = Prompt("Введите количество строк второй матрицы: ");
int cols2 = Prompt("Введите количество столбцов второй матрицы: ");
int [,] secondArray = new int[rows2, cols2];
FillArray(secondArray);
PrintArray(secondArray);

int [,] resultArray = new int[rows2, cols2];
int [,] matrixProd = MatrixProduct(resultArray);

if (ValidateMatrixProduct(firstArray, secondArray))
{
    Console.WriteLine("Произведение матриц: ");
    PrintArray(matrixProd);
}
else
{
    Console.WriteLine("Произведение матриц невозможно");
}

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

bool ValidateMatrixProduct(int[,] firstMartrix, int[,] secomdMartrix) // Метод проверки на возможность умножение матриц
{
    if (firstArray.GetLength(1) == secondArray.GetLength(0)) return true;
    else return false;
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
                resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return array;
}