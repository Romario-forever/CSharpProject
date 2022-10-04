using System;

namespace HomeWork
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Задача 34");
            Console.WriteLine();
            //Задайте массив заполненный случайными положительными трёхзначными числами. 
            //Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2
            
            int[] plusNumbers = new int[4];
            
            int[] numbers = plusNumbers;
            int length = numbers.Length;
            int index = 0;
                
                while (index < length)
                {
                    numbers[index] = new Random().Next(99, 1000);
                    index++;
                    Console.WriteLine(numbers(index));
                }
            
            
            /*void PrintArray(int[] values)
            {
                int count = values.Length;
                int position = 0;
                while (position < count)
                {
                    Console.WriteLine(values(position));
                    position++;
                }
            }*/
            
            //FillArray(plusNumbers);
            //PrintArray(plusNumbers);




        }
    }

}





