// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Проверим является ли число палиндромом");
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    string num1 = num.ToString();
    char[] ar = num1.ToCharArray();
    Array.Reverse(ar);
    num1 = new String(ar);
    int num2 = Convert.ToInt32(num1);
    Console.WriteLine(num2);

    if (num = num2)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

