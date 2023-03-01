// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 6] -> 0

int ArrayLength = InputInt("Введите длинну массива: ");
int minValue = InputInt("Введите минимальное значение массива: ");
int maxValue = InputInt("Введите максимальное значение массива: ");

int InputInt(string message) // Метод ввода массива
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[ArrayLength]; // Определения длины массива
Console.Write($"Массив: [");
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
    Console.Write(array[i] + " ");
}
Console.WriteLine($"]");

int SumOfOddElements(int[] array) // Метод вычисления суммы нечетных элементов массива
{
    int Sum = 0; // Инициализация переменной, в которой будем считать сумму нечетных элементов
    for(int j = 0; j < array.Length; j += 2)
    {
        Sum = Sum + array[j];
    }
    return Sum;
}

void PrintArray(int[] array) // метод вывода массива
{
    Console.WriteLine($"Cумма нечётных элементов массива равна: {SumOfOddElements(array)}");
}

PrintArray (array);