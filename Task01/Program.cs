//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
//а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите два числа:");

int Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 > Number2)
{
    System.Console.Write($"Максимальное число: {Number1}");
}
else
    System.Console.Write($"Максимальное число: {Number2}");