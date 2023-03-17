// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int firstNumber = Prompt("Введите число M: ");
int secondNumber = Prompt("Введите число N: ");

Console.WriteLine($"Все четные числа от {firstNumber} до {secondNumber}: ");
GetEvenNumbers(firstNumber, secondNumber);

int Prompt (string message)
{
    Console.Write(message);
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("Вы ввели не верный диапазон чисел");
    Environment.Exit(1);
    return 0;
}

void GetEvenNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber) return;
    if (firstNumber % 2 == 0) Console.Write($"{firstNumber}\t");
    GetEvenNumbers(firstNumber + 1, secondNumber);
}