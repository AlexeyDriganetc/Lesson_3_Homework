﻿Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0) 
{
    Console.Write("Вы ошиблись!\nВторое число должно быть положительное: ");
    m = int.Parse(Console.ReadLine()!);
}
int result = 1;

for (int i = 1; i <= m; i++)
result = result * n;

Console.WriteLine($"Результат: {result}");