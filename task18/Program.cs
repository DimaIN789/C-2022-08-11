﻿// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатной четверти");
int num = Convert.ToInt32(Console.ReadLine());


if (num == 1)
{
  Console.WriteLine("Диапазон возможных координат точек: X > 0 и Y > 0");  
}
else if (num == 2)
{
  Console.WriteLine("Диапазон возможных координат точек: X < 0 и Y > 0");  
}
else if (num == 3)
{
  Console.WriteLine("Диапазон возможных координат точек: X < 0 и Y < 0");  
}
else if (num == 4)
{
  Console.WriteLine("Диапазон возможных координат точек: X > 0 и Y < 0");  
}
else 
{
  Console.WriteLine("В декартовой системе координат 4 диапазона. Вы ввели несуществующий диапозон");  
}
