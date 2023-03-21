Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 51); // [1, 50]

Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
