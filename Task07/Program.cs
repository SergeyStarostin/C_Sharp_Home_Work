// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool WeekDay(int Day)
{
    if (Day > 5 && Day < 8)
    {
        return true;
    }
    return false;
}

bool TheDayOfWeek(int Day)
{
    if (Day > 0 && Day < 8)
    {
        return true;
    }
        return false;
}

int Day = Prompt ("Введите день недели: ");

if (TheDayOfWeek(Day))
{
    if (WeekDay(Day))
    {
        Console.WriteLine ($"{Day} день выходной");
    }
    else
    {
        Console.WriteLine ($"{Day} будний день");
    }
}
else
    {
        Console.WriteLine ($"{Day} день недели еще не придумали");
    }