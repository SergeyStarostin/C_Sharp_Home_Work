//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("Введите три числа:");

int Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = Convert.ToInt32(Console.ReadLine());
int Number3 = Convert.ToInt32(Console.ReadLine());
int max = Number1;

if (Number1 < Number2)
{
    max = Number2;
    if (max < Number3)
    {
        max = Number3;
    }
    System.Console.Write($"Максимальное число: {max}");
}
else
    System.Console.Write($"Максимальное число: {max}");