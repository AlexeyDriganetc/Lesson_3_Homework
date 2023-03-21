void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [0; 11]
}

int Shift(int[] array)
{
    int buffer = array[0];

    for (int m = 0; m < array.Length - 1; m++)
    {
    array[m] = array[m+1];
    }

    array[array.Length-1] = buffer;
   
    return array;
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
while (k < -100000 || k > 100000) 
{
    Console.Write("Вы ошиблись!\nЧисло должно до 100 000 по модулю: ");
    k = int.Parse(Console.ReadLine()!);
}

Console.WriteLine(Shift(array));

Console.WriteLine($"Сдвинутый массив: [{string.Join(", ", array)}]");
