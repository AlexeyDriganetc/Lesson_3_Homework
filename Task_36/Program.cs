// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(10, 101); // [10, 100]
}

Console.Clear();
int sumOddPositions = 0;
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

    for (int i = 0; i < array.Length; i = i+2)
     sumOddPositions += array[i];

    Console.Write($"Сумма нечётных позиций: {sumOddPositions}");
