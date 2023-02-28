// Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int SearchTwoDigits(int[] array)    // метод поиска двухзначных чисел 
{
    int countDigits = 0;               // счетчик
    for (int i = 0; i < array.Length; i++)  // цикл перебора
    {
        if (array[i] > 9 && array[i] < 100) countDigits++; // если условие выполняется то увеличиваем счетчик
    }
    return countDigits;    // возвращаем значение
}

int size = 10;
int minValue = 1;
int maxValue = 200;
int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
System.Console.WriteLine($"Количество двухзначных элементов = {SearchTwoDigits(myArray)}");
