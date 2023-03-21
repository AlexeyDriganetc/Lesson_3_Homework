
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 10000 || n > 99999)
{
    Console.Write("Вы ошиблись!\nВведите число: ");
    n = int.Parse(Console.ReadLine()!);
}
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");



// else
//   if ((Convert.ToInt32(n[0].ToString())) == (Convert.ToInt32(n[4].ToString()))
//    && (Convert.ToInt32(n[1].ToString())) == (Convert.ToInt32(n[3].ToString())));
//    Console.Write("Yes");
//    else
//    {
//     Console.Write("No");
//    }
