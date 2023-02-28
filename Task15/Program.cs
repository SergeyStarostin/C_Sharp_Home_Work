// Задача 1: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] InvertArray(int[] array)              // метод возвращает число противоположного знака 
{
    for (int i = 0; i < array.Length; i++)  // перебор массива
    {
        array[i] *= -1;                     // меняем знак числа
    }
    return array;                           // возвращаем массив
}

int size = 12;
int minValue = -9;
int maxValue = 9;

int[] myArray = GenerateArray(size, minValue, maxValue);
PrintArray(myArray);
InvertArray(myArray);
PrintArray(myArray);
