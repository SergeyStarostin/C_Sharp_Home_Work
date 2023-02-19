// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// //вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Number = Prompt("Введите трехзначное число: ");

if (Number > 99 && Number < 1000)
{
    int SecondNumber = Number % 100 / 10;
    System.Console.Write($"Вторая цифра трехзначного числа = {SecondNumber}");
}
else
{
    System.Console.Write($"{Number} не является трехзначным");
}