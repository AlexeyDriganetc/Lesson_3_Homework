﻿// Console.Clear();
// Console.Write("Введите число: ");
// // string k = Console.ReadLine();
// // int l = k.Length;
// string n = Console.ReadLine();
// int sum = 0;
// int m = 0;
// int l = 0;

// if (n.Length >= l)
// {
// for (int i = 0; i <= ; i++)
// {
// m = Convert.ToInt32(n[i].ToString());
// sum = sum + m;
// l++;
// }
// }

// Console.WriteLine(sum);

Console.Clear();
Console.Write("Введите число: ");

int n = int.Parse(Console.ReadLine());
int sum = 0;

while (n > 0)
{
sum += n % 10;
n /= 10;
}

Console.WriteLine (sum);