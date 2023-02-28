// Задача 1
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Проверка без применения строк

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputInt(string message)
{
    System.Console.Write($"{message}> ");            //вывод приглашения ко вводу координат
    int value;                                       //инициализация переменной
    if (int.TryParse(Console.ReadLine(), out value)) //проверка условия корректности ввода + ввод со строки
    {                                                //если конвертация строки прошла правильно, то мы попадаем в ветку, 
        return value;                                //которая находится в скобках после наименования функции.
    }                                                //Если да, то выдает первое значение (ввод со строки). Нет - второе (out )
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                             //если TryParse не сработало, выходим из программы (Exit) с кодом 1 (нужна для компиляции)
    return 0;
}

bool Palindrome (int number)
{
    if (number / 10000 == number % 10)
    {
        if (number / 1000 % 10 == number / 10 % 10)
        {
            return true;
        }
    }
    return false;
}
int number = InputInt("Введите пятизначное число: ");

if (Palindrome(number))
{
    System.Console.Write($"Число зеркальное");
}
else
{
    System.Console.Write($"Число не зеркальное");
}
