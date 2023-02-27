// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int DegreeOfNumber (int Degree, int Number)
{
    int Num = 1;
    for (int i = 0; i < Degree; i++ )
    {
        Num *= Number;
    }
    return Num;
}
bool Validate (int Degree)
{
    if (Degree < 0)
    {
        Console.WriteLine($"Степень должна быть натуральной");
        return false;
    }
    return true;
}
int Number = Prompt ($"Введите число: ");
int Degree = Prompt ($"Введите степень: ");
if (Validate(Degree))
{
    Console.WriteLine($"{Number} в степени {Degree} равно {DegreeOfNumber (Degree, Number)}");
}
