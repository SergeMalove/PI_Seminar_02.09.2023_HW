// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(minValue, maxValue + 1);
}

// Метод не участвует в проверке. Нужен просто для самопроверки и тестирования.
void PrintArray(int[] array)
{
    foreach (int number in array)
        Console.Write($"{number} ");
    Console.WriteLine();
}

// Это метод по основному заданию
int OddIndexSumCalculate(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
        result += array[i];
    return result;
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[] array = CreateArray(size);
FillArray(array, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"В данном массиве сумма элементов стоящих на нечётных позициях равна {OddIndexSumCalculate(array)}");