// Задача доп
// развернуть массив

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());

    string num1 = num.ToString();
    char[] ar = num1.ToCharArray();
    Array.Reverse(ar);
    num1 = new String(ar);
    

    Console.WriteLine(num1);
