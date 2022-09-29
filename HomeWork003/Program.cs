using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine();
            Console.WriteLine("Задача 19");
            //Напишите метод, который принимает на вход пятизначное число
            //и проверяет, является ли оно палиндромом.

            int number = 257486;
            int current_number = number;
            int result = 0;

            if (number > 9999 && number < 100000)
            {
                Console.WriteLine("Это пятизначное число");
            }
            else
            {
                Console.WriteLine("Это не пятизначное число");
            }
            while (current_number > 0)
            {
                int digit = current_number % 10;
                result = result * 10 + digit;
                current_number /= 10;
                Console.WriteLine(result);
            }
            if (number == result)
            {
                Console.WriteLine($"Число {number} палиндром");
            }
            else
            {
                Console.WriteLine($"Число {number} не палиндром");
            }

            /*Console.WriteLine();
            Console.WriteLine("Задача 21");
            // Напишите метод, который принимает на вход координаты двух точек
            // и находит расстояние между ними в 3D пространстве.

            int a_x = 5, a_y = 2, a_z = 3;
            int b_x = 1, b_y = 2, b_z = 5;              
            

            double result = Math.Sqrt(Math.Pow(a_x - b_x, 2)
                                + Math.Pow(a_y - b_y, 2)
                                + Math.Pow(a_z - b_z, 2));

            Console.WriteLine(result);*/


            Console.WriteLine();
            Console.WriteLine("Задача 23");
            //Напишите метод, который принимает на вход число (N) 
            //и выдаёт таблицу кубов чисел от 1 до N.

            int digit = 13;

            for (int i = 1; i <= digit; i++)
            {
                Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
            }





        }
    }
}