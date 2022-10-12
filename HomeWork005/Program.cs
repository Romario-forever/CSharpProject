using System;

namespace HomeWork
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Задача 34");
            Console.WriteLine();
            //Задайте массив заполненный случайными положительными трёхзначными числами. 
            //Напишите программу, которая покажет количество чётных чисел в массиве.
            
            int[] GenerateRandomArray(int size, int start, int end)
            {
                //объявляем массив размера size( количество элементов = size)
                // это выделена область памяти для переменных типа int 
                //(количество переменных = size)
                int[] randomArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                //Генерируем число из диапазона [start;end] и записываем его в i-йэлемент массива
                    randomArray[i] = new Random().Next(start, end + 1);
                }
                
                return RandomArray;
            }

            //Метод для вывода элементов массива в консоль для вывода на экрана
            //передаём "()" в метод ShowArray массив "int[] "
            void ShowArray(int[] Array1)
            {
                for (int i = 0; i < Array1.Length; i++)
                {
                    Console.WriteLine(Convert.ToString(Array1[i]));
                }
            }

            // Проверка количества чётных чисел (элементов) массива
            int CountOfEven(int[] myArray2)
            //передаём "()" в метод ShowArray массив "int[] "
            {
                
                int Count = 0;
                for (int i = 0; i < myArray2.Length; i++)
                    if (myArray2[i] % 2 == 0)
                    {
                        Count = Count + 1;
                    }
                return Count;
            }

            int[] myArray = new int[5];
            myArray = GenerateRandomArray(5, 100, 999);
            ShowArray(myArray);
            Console.WriteLine("количество четных чисел массива " + CountOfEven(myArray));
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Задача 36");
            Console.WriteLine();
            //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
            //Найдите сумму элементов, стоящих на нечётных позициях.
       
            Console.Write($"Введи количество элементов массива: ");
            int numberElements = Convert.ToInt32(Console.ReadLine());

            int RandomNumbers(int numberElements, int min, int max)
            {
                int[] randomNumbers = new int[numberElements];
                int sumElements = 0;
                Console.Write("Получившийся массив: ");

                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    randomNumbers[i] = new Random().Next(min, max);

                    Console.Write(randomNumbers[i] + " ");

                    if (i % 2 != 1)
                    {
                        sumElements = sumElements + randomNumbers[i];
                    }
                }
                return sumElements;
            }

            int randomNumbers = RandomNumbers(numberElements, 1, 30);

            Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

          
            Console.WriteLine();
            Console.WriteLine("Задача 38");
            Console.WriteLine();
            //Задайте массив вещественных чисел. Найдите разницу между максимальным
            // и минимальным элементов массива.
           
            int Find(int[] array)
                {
                    int result = 0;
                    int min = 0;
                    int max = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[min] > array[i])
                            min = i;
                        else if (array[max] < array[i])
                            max = i;
                    }
                    Console.WriteLine("min = " + array[min] + "\tmax = " + array[max]);
                    if (array[min] > array[max])
                        result = array[min] - array[max];
                    else if (array[max] > array[min])
                        result = array[max] - array[min];
                    return result;
                }
            
            Console.Write("введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.Write("введите минимальное значение: ");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите максимальное значение: ");
            int Max = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            if (Min > Max)
            {
                temp = Max;
                Max = Min;
                Min = temp;
            }
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(Min, Max);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + "\t");

          
            Console.WriteLine("разница между минимальным и максимальным элементом массива = " + Find(array));
            
        }
    }

}










