// Задача № 2: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//  M = 1; N = 15-> 120
//  M = 4; N = 8. -> 30

int firstNumber = Prompt("Введите число M: ");
int secondNumber = Prompt("Введите число N: ");

GetSumFromMToN(firstNumber, secondNumber);
Console.WriteLine($"\nСумма всех натуральных элементов в промежутке от {firstNumber} до {secondNumber} = {GetSumFromMToN(firstNumber, secondNumber)}");

int Prompt (string message)
{
    Console.Write(message);
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) return value;
    Console.WriteLine("Вы ввели не верный диапазон чисел");
    Environment.Exit(1);
    return 0;
}

int GetSumFromMToN(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber) return 0;
    return firstNumber + GetSumFromMToN(firstNumber + 1, secondNumber);
}