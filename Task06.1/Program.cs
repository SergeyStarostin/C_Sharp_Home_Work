//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Prompt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int ThirdNumber (int Number)

{
    while (Number > 999)
    {
        Number /= 10;
    }
    return Number % 10;
}

bool ValidateNumber (int Number)
{
    if (Number < 100)
    {
        System.Console.Write($"в числе {Number} нет третьей цифры");
        return false;
    }
    return true;
}

int Number = Prompt ("Введите число: ");

if (ValidateNumber(Number))
{
    Console.WriteLine(ThirdNumber(Number));
}
