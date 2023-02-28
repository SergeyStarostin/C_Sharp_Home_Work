// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] FillArray (int size)  // метод заполнения массива
{
    int[] myArray = new int[size]; // объявление и иницифлизация массива
    for (int i = 0; i < myArray.Length; i++) // цикл перебора массива
    {
        myArray[i] = new Random().Next(0, 100); // кладем в каждый элемет массива рандомное число от 0 до 1
    }
    return myArray; //  возвращаем массив
}

int InputSizeArray(string msg) // метод ввода числа
{
    System.Console.Write($"{msg}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array) // метод вывода массива
{
    for (int i = 0; i < array.Length; i++) // цикл перебора массива
    {
        System.Console.Write($"{array[i]}, "); // на каждой итерации цикла мы будем выводить элемент массива
    }
}

int sizeArray = InputSizeArray("Введите размер массива"); // вводим количество элементов массива и кладем в переменную
int[] myArray = FillArray(sizeArray); // заполняем массив рандомным числом от 0 до 100
Console.Write($"[");
PrintArray(myArray);
Console.Write($"]");