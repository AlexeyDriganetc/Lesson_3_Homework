// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//  l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2+ (z 2 - z 1) 2) 
//  l - расстояние между точками 
//  x 1, y 1, z 1 - координата первой точки 
//  x 2, y 2, z 2 - координата второй точки.

Console.Clear();
Console.Write("Введите координату X(1): ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(1): ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z(1): ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.ReadLine();

Console.Write("Введите координату X(2): ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(2): ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z(2): ");
double z2 = Convert.ToDouble(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 2)}");