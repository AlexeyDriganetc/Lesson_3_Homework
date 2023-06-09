﻿// Дана последовательность из N целых чисел и число K. 
// Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
// на |K| элементов вправо, если K – положительное и влево, 
// если отрицательное.

// 5 3 7 4 6  (шаг на +3) (Пример не правильный.)
// 7 4 6 5 3

// 5 3 7 4 6  (шаг на -3)
// 4 6 5 3 7

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [0; 11]
}

void Shiftpositive(int[] array)
{

    int buffer = array[array.Length-1];

    for (int m = array.Length - 1; m > 0; m--)
    {
        array[m] = array[m-1];
    }

    array[0] = buffer;
}

void Shiftnegative(int[] array)
{
    int buffer = array[0];

    for (int m = 0; m < array.Length - 1; m++)
    {
        array[m] = array[m+1];
    }

    array[array.Length-1] = buffer;
}

Console.Clear();
Console.Write("Введите кол.элементов в массиве\nЧисло N: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 0 || n > 100000) 
{
    Console.Write("Вы ошиблись!\nЧисло должно от 1 до 100 000: ");
    n = int.Parse(Console.ReadLine()!);
}

int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

Console.Write("Введите шаг сдвига\nЧисло K: ");
int k = int.Parse(Console.ReadLine()!);
while (k < -100000 || k > 100000 || k == 0) 
{
    Console.Write("Вы ошиблись!\nЧисло должно до 100 000 по модулю и не равно 0: ");
    k = int.Parse(Console.ReadLine()!);
}

if (k > 0)
for (int l = 1; l <= k; l++)
{
Shiftpositive(array);
}

if (k < 0)
for (int h = -1; h >= k; h--)
{
Shiftnegative(array);
}
Console.WriteLine($"Сдвинутый массив: [{string.Join(", ", (array))}]");

