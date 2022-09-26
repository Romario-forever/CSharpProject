using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine();
            Console.WriteLine("Задача 10");
            // Напишите программу, которая принимает на вход трёхзначное число 
            // и на выходе показывает вторую цифру этого числа.

            Console.WriteLine("Введите трехзначное число: ");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            string stringNumber = Convert.ToString(threeDigitNumber);
            Console.WriteLine("Вторая цифра этого цисла: " + stringNumber[1]);*/


            Console.WriteLine();
            Console.WriteLine("Задача 13");
            //Напишите программу, которая выводит третью цифру заданного числа 
            //или сообщает, что третьей цифры нет.

            Console.Write("Введи число: ");
            int anyNum = Convert.ToInt32(Console.ReadLine());
            string anyNumText = Convert.ToString(anyNum);
            if (anyNumText.Length > 2)
            {
                Console.WriteLine("Третья цифра:" + anyNumText[2]);
            }
            else
            {
                Console.WriteLine("Третьей цифры нет");
            }
        }
    }
}



