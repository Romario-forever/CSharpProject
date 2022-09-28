using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Задача 10");
            // Напишите программу, которая принимает на вход трёхзначное число 
            // и на выходе показывает вторую цифру этого числа.

            Console.WriteLine("Введите трехзначное число: ");
            int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
            string stringNumber = Convert.ToString(threeDigitNumber);
            Console.WriteLine("Вторая цифра этого цисла: " + stringNumber[1]);


            Console.WriteLine();
            Console.WriteLine("Задача 13");
            //Напишите программу, которая выводит третью цифру заданного числа 
            //или сообщает, что третьей цифры нет.

            Console.Write("Введите число: ");
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

            Console.WriteLine();
            Console.WriteLine("Задача 15");
            // Напишите программу, которая принимает на вход цифру, обозначающую день недели,
            // и проверяет, является ли этот день выходным.
            Console.Write("Введите цифру, обозначающую день недели: ");
            int numberDayWeek = Convert.ToInt32(Console.ReadLine());

            void CheckingTheDayOfTheWeek(int numberDayWeek)
            {
                if (numberDayWeek == 6 || numberDayWeek == 7)
                    Console.WriteLine("Это выходной день");

                else if (numberDayWeek < 1 || numberDayWeek > 7)
                    Console.WriteLine("Это НЕ ДЕНЬ недели!");

                else Console.WriteLine("Это НЕ выходной день");
            }
            CheckingTheDayOfTheWeek(numberDayWeek);
            
            Console.WriteLine();
            Console.WriteLine("Задача 228");
            // Напишите программу, которая принимает на вход семь чисел, 
            // и находит их среднее арифметическое

            int array;
            int x;
            int sum = 0;
            int rezult;

            Console.WriteLine("Введите количество чисел");
            array = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < array; i++)
            {

                Console.WriteLine("Введите заданное количество чисел");
                x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }

            rezult = sum / array;

            Console.WriteLine(rezult);

        }
    }
}



