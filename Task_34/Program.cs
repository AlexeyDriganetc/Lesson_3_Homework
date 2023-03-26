// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 999]
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int m = 0;
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
    for (int i = 0; i < array.Length; i++)
     if (array[i] % 2 == 0)
     m += 1;
    Console.Write($"Чётных чисел - {m}");