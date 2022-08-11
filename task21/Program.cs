// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// √(xb - xa)2 + (yb - ya)2

// Math.Pow(1,2) - возвести число которое слева в степень которая справа
// Math.Sqrt(25) - получить квадратный корень

Console.WriteLine("Найдем расстояние между точками в 2D пространстве");
Console.WriteLine("Введите координату по х точки А");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату по y точки А");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату по х точки B");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату по y точки B");
double yb = Convert.ToDouble(Console.ReadLine());

// double num1 = (xb - xa);
// double num2 = (yb - ya);

// double num12 = Math.Pow(num1,2);
// double num22 = Math.Pow(num2,2);

// double num3 = (num12 + num22);

// double n = Math.Sqrt(num3);

double n = Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));

Console.WriteLine($"{n:f2}");


// f2 - обрубить хвост, количество значений после запятой 

