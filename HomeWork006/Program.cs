// Console.WriteLine();
// Console.WriteLine("Задача 41");
// Console.WriteLine();
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/*void Zadacha41()
{
    Console.Write("Введите числа(через пробел): ");
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Кол-во чисел > 0: {count}");
}


Zadacha41();*/

Console.WriteLine();
Console.WriteLine("Задача 43");
Console.WriteLine();
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)

void Zadacha43()
{
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());


    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

Zadacha43();