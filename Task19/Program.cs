
// Задача № 1: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] FillArray(int[] array) // Метод заполнения массива случайными трехзначными числами 
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    System.Console.WriteLine(); 
    return array;
}

int ShowEvanNumbers(int[] array) // Метод, подсчитывающий количество четных чисел в массиве
{
    int result = 0; // Инициализация переменной, в которой будем складывать результат
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}

void PrintArray(int[] array) // Метод вывода на экран массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}

int userNumber = Prompt("Введите количество элементов в массиве: ");
int[] myArray = new int[userNumber];
FillArray(myArray);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {ShowEvanNumbers(myArray)}");