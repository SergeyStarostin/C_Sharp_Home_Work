// Задача № 5: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

//Проверка: 
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Метод создания массива с длинной и минимальным и максимальным значением
int[] GenerateArray(int length, int minValue, int maxValue) // Название метода
{
    int[] result = new int[length]; // Создание массива заданной длинной 
    Random rnd = new Random(); // Создание генератора случайных чисел
    for (int i = 0; i < result.Length; i++) // Цикл элементого перебора массива
    {
        result[i] = rnd.Next(minValue, maxValue + 1); // Поэлементное заполнение массива случайными числами 
    }
    return result; //Возвращаем массив из метода
}

// Метод произведения пары чисел в массиве
int[] PairsArray(int[] array) // Название метода 
{
    int[] result = new int[array.Length / 2 + array.Length % 2]; // Создание массива с длинной пополам от длины массива + кратно двум
    result[result.Length - 1] = array[result.Length - 1]; // Передача значений массива в новый массив
    for (int i = 0; i < array.Length / 2; i++) // Цикл с поэлементным перебором массива
    {
        int lastIndex = array.Length - 1 - i; //
        result[i] = array[i] * array[lastIndex]; // Умножение элементов массива
    }
    return result; // Возвращение массива из метода
}

// Метод вывода на экран массива
void PrintArray(int[] array) // Название массива 
{
    for (int i = 0; i < array.Length; i++) // Поэлементное обращение к массиву
    {
        System.Console.Write(array[i] + " "); // Вывод на экран элемента  массива и пробела 
    }
    System.Console.WriteLine(); // Вывод на экран пустой строки для красоты 
}

int[] array = GenerateArray(8, 1, 6);
PrintArray(array);
PrintArray(PairsArray(array));