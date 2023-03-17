// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Для построения функции используется последовательность a + b, a * b, a в степени b,..., в которой каждый следующий оператор определяется так, 
// что предыдущий оператор применяется b - 1 раз к числу a.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int firstNumber = Prompt("Введите число m: ");
int secondNumber = Prompt("Введите число n: ");

Ackermann(firstNumber, secondNumber);
Console.WriteLine($"A({firstNumber}, {secondNumber}) = {Ackermann(firstNumber, secondNumber)}");

int Prompt (string message)
{
    Console.Write(message);
    int value;
    if (int.TryParse(Console.ReadLine(), out value)) return value;
    Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int Ackermann(int firstNumber, int secondNumber) // Метод вычисления функции Аккермана
{
    if (firstNumber == 0) return secondNumber + 1;
    else if (secondNumber == 0 && firstNumber > 0) return Ackermann(firstNumber - 1, 1);
    else return Ackermann(firstNumber - 1, Ackermann(firstNumber, secondNumber - 1));
}