// Задача 38: Задайте массив дробных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3,01 7,23 22,79 2,38 78,45] -> 76,07


void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (100 - 10) + 10, 2); // [10, 100]
}

Console.Clear();

Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
Double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
double max = array[0];
double min = array[0]; 

    for (int i = 0; i < array.Length; i++)
    {
     if (array[i] < min)
     min = array[i];
     if (array[i] > max)
     max = array[i];
    }
     
    Console.Write($"Разница: {max} - {min} = {Math.Round(max-min,2)}");