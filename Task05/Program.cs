// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// //вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 99 && Number < 1000)
{
    int SecondNumber = Number % 100 / 10;
    System.Console.Write($"Вторая цифра трехзначного числа = {SecondNumber}");
}
else
{
    System.Console.Write($"{Number} не является трехзначным");
}     