// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int ArrayLength = InputInt($"Введите длинну массива: ");
int minValue = InputInt($"Введите минимальное значение массива: ");
int maxValue = InputInt($"Введите максимальное значение массива: ");

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

int FindMinNumber(int[] array) // Метод нахождения минимального элемента массива
{
    int min = array[0]; // Присвоение переменной min значение 0-го элемента массива
    for (int i = 0; i < array.Length; i++) // Цикл перебора массива
    {
        if (min > array[i]) // Условие нахождения минимального значения 
            min = array[i]; // Перезаписывание переменной с минимальным значением, если условие выполнено
    }
    return min; // Возвращение минимального значения из метода
}

int FindMaxNumber(int[] array) // Метод нахождения максимального элемента массива 
{
    int max = array[0]; // Присвоение переменной max значение 0-го элемента массива
    for (int i = 0; i < array.Length; i++) // Цикл перебора массива по элементно
    {
        if (max < array[i]) // Условие нахождения максимального значения 
            max = array[i]; // Перезаписывание переменной с максимальным значением, если условие выполнено
    }
    return max; // Возвращение максимального значения из метода
}

void PrintArray(int[] array) // метод вывода массива
{
    int Difference = FindMaxNumber(array) - FindMinNumber(array);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {FindMaxNumber(array)} - {FindMinNumber(array)} = {Difference}");
}

PrintArray(array);