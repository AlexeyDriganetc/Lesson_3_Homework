﻿// Требуется написать программу, производящую разложение заданного чётного числа 
// согласно утверждению Гольдбаха - 
// Любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, 
// причём таких разложений может быть несколько.,
// . Из всех пар простых чисел,
// сумма которых равна заданному числу, требуется найти пару, 
// содержащую наименьшее простое число.

// Входной файл INPUT.TXT содержит чётное число N (4 ≤ N ≤ 998).
// необходимо вывести два простых числа, сумма которых равна числу N. 
// Первым выводится наименьшее число.

// Пример:
// 6	3 3
// 992	73 919

// void Goldbach(ref int x, ref int y)
// {
//     x = x + 10;
// }


// Console.Clear();
// int n = 5;
// f(ref n);
// Console.WriteLine(n);


// for (int i = 2; i < x; i++)
// if ( x % i == 0)
//     return false;
//return true;


Console.Clear();
Console.Write("Введите чётное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n % 2 > 0) 
{
    Console.Write("Вы ошиблись!\nЧисло должно быть чётным: ");
    n = int.Parse(Console.ReadLine()!);
}

while (n < 6 || n > 998) 
{
    Console.Write("Вы ошиблись!\nЧисло должно от 6 до 998: ");
    n = int.Parse(Console.ReadLine()!);
}

int y = 0;
// int x = 3;
for (int x = 3; x + y <= n; x += 2)
{
// while (x + y <= n)
  int i = 2;
  while (x % i != 0)
     i++; 
         if (i == x)
             y = n - x;
             int m = 2;
                 while (y % m != 0)
                     m++; 
                         if (m == y)
                             Console.WriteLine($"{n} = {x} + {y}");
                         else x += 2;



}







