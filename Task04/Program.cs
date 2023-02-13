//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число N: ");

int Number = Convert.ToInt32(Console.ReadLine());   // вводим число N

       int count = 1;                               // начало отсчета
       while (count < Number)                       // пока count < Number, цикл выполняется
       {
            System.Console.Write($"{count +1} | "); // вывод на экран четное число
            count += 2;                             // увеличиваем count на 2
       }
