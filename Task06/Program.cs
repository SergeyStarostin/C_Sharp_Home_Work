//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Решение без использования методов (функций)
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99)
{
    while (Number > 1000)
    {
        Number = Number / 10;
    }
int ThirdNumber = Number % 10;
System.Console.Write($"Третья цифра числа = {ThirdNumber}");
}
else
{
    System.Console.Write($"в числе {Number} нет третьей цифры");
}