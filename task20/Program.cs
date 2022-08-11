// Задача 20
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// √((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2).

// Math.Pow(1,2) - возвести число которое слева в степень которая справа
// Math.Sqrt(25) - получить квадратный корень


Console.WriteLine("Найдем расстояние между точками в 2D пространстве");
Console.WriteLine("Введите координату точки А");
Console.WriteLine("по х:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("по y:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("по z:");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату точки B");
Console.WriteLine("по х:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("по y:");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("по z:");
double zb = Convert.ToDouble(Console.ReadLine());

// √((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2).
double n = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));

Console.WriteLine($"{n:f2}");

// f2 - обрубить хвост, количество значений после запятой 