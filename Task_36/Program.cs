// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (100 - 10) + 10, 0); // [10, 100]
}

Console.Clear();

Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
Double[] array = new double[n];

double sumOddPositions = 0;
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// int[] array = {3, 7, 23, 12};  Проверка примера
// int[] array = {-4, -6, 89, 6}; 
// int sumOddPositions = 0;

    for (int i = 1; i < array.Length; i = i+2)
     sumOddPositions += array[i];

    Console.Write($"Сумма нечётных позиций: {sumOddPositions}");
