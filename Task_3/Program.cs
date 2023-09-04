// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    return new double[size];
}

void FillArray(double[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.NextDouble() * (maxValue - minValue) + minValue, 2);
}

// Метод не участвует в проверке. Нужен просто для самопроверки и тестирования.
void PrintArray(double[] array)
{
    foreach (double number in array)
        Console.Write($"{number} ");
    Console.WriteLine();
}

// Это метод по основному заданию
double MinMaxDifference(double[] array)
{
    if (array.Length == 0)
    {
        throw new Exception("Задан пустой массив");
    }
    double minValue = array[0];
    double maxValue = array[0];

// Вот тут можно пойти циклом for со второго элемента, т.к. на шаг выше значение первого элемента уже присвоены,
// но мне больше нравится запись цикла foreach, пусть оно и на одну итерацию будет больше.
    foreach (double number in array)
    {
        if (number < minValue)
            minValue = number;
        if (number > maxValue)
            maxValue = number;
    }
    return Math.Abs(maxValue - minValue);
    // Решение в одну строку с использованием встроенных функций C#:
    // return Math.Round(Math.Abs(array.Max() - array.Min()), 2);
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
double[] array = CreateArray(size);
FillArray(array, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"В данном массиве разница между минимальным и максимальным элементом равна {MinMaxDifference(array)}");