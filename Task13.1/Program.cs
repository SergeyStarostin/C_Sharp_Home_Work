// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

int lenArray = InputInt("Введите длинну массива: ");
int minValue = InputInt("Введите минимальное значение массива: ");
int maxValue = InputInt("Введите максимальное значение массива: ");

// Функция ввода данных для массива:
int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода массива с условиями:
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(minValue,maxValue + 1);
    Console.Write(randomArray[i] + " ");
}
System.Console.WriteLine();