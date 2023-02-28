// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Функция генерирует массив с заданными параметрами (длина, максимальное и минимальное значение)
int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];             // Создание массива с длиной length
    var rnd = new Random();                  // Создание генератора случайных чисел

    // Цикл заполнения результирующего массива случайными числами из диапазона между minValue и maxValue
    for (int i = 0; i < result.Length; i++) // инициализируем i (индекс) для перавого элемента массива, пока этот индекс будет меньше длины массива, будет крутить цикл, в конце цикла увеличим i на 1
    {
        result[i] = rnd.Next(minValue, maxValue + 1);    // присваиваем случайное число элементу массива
    }

    return result;      // Возвращаем массив из функции
}

// Вывод массива
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

//Функция возвращает сумму элементов с заданным знаком
int SumSign(int[] array, bool isPositive = true)
{
    int sign = 1;           // Знак прогверки числа ( что оно положительное или отрицательное)
    if (!isPositive)        // Если мы считаем отрицательные, то знак перевернуть
    {
        sign = -1;
    }

    int sum = 0;  // Сумма накопления
    for (int i = 0; i < array.Length; i++) // цикл перебора по массиву
    {
        if (array[i] * sign > 0)           // определение знака элемента массива
        {
            sum += array[i];               // накапливаем сумму
        }
    }
    return sum;
}

int size = 12;
int minValue = -9;
int maxValue = 9;
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
int sumPositive = SumSign(array);
System.Console.WriteLine($"Сумма положительных элементов массива равна {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных элементов массива равна {SumSign(array, false)}");
