// Напишите программу для подсчета общего количества повторяющихся элементов в массиве.
// Необходимо только посчитать количество разных чисел, которые повторяются в массиве.
// Пример.
// [1, 0, 1, 5, 3, 9, 3, 4, 5, 3] -> 3 (так как повторяются три числа: 1, 5 и 3)

// P. S. Фиксировать значения чисел не обязательно.

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

void PrintArray(int[] array)
{
    foreach (int number in array)
        Console.Write($"{number} ");
    Console.WriteLine();
}

void SortArray(int[] array) // Взял немного допиленный вариант Пузырьковой сортировки и переделал на свой вкус
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        bool flag = true;
        int min = i;
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                flag = false;
            }
            if (array[j] < array[min])
                min = j;
        }
        if (flag)
            break;
        if (min > i)
            (array[i], array[min]) = (array[min], array[i]);
    }
}

int RepeatedNumCalculate(int[] array)
{
    int result = array[0] == array[1] ? 1 : 0;
    int temp = array[0];

    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i - 1] != array[i] && array[i] == array[i + 1])
            result++;
    }
    return result;
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[] array = CreateArray(size);
FillArray(array, minValue, maxValue);
Console.WriteLine("Исходный массив:\n");
PrintArray(array);
Console.WriteLine("\nОстортированный массив:\n");
SortArray(array);
// Array.Sort(array);  // Можно воспользоваться встроенной функцией сортировки массива.
PrintArray(array);
Console.WriteLine($"В данном массиве числа повторяются {RepeatedNumCalculate(array)} раз.");