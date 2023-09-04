// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

// По заданию надо трех значные числа, но как бы пусть будет универсальная функция.
// Что бы были трехзначные цисла вводим 100 и 999, как минимум и максимум.
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
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

int EvenCalculate(int[] array)
{
    int result = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
            result++;
    }
    return result;
}



int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
int[] array = CreateArray(size);
FillArray(array, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"В данном массиве {EvenCalculate(array)} четных чисел.");