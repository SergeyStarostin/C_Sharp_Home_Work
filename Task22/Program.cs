// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt (string message) // метод считывания чисел с консоли
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

int[] FillArray (int size) // метод заполнения массива пользователем
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt ($"Введите {i + 1}-е число = "); // прибавляем 1 потому, что 1-й индекс = 0
    }
    return array;
}

void PrintArray(int[] array) // метод вывода массива
{
    Console.WriteLine($"Количество положительных чисел = {CountPositiveNumbers (array)}");
}

int CountPositiveNumbers (int[] array) // метод подсчета положительных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int size = Prompt("Введите количество чисел: ");
int [] array;
array = FillArray (size); 
PrintArray(array);