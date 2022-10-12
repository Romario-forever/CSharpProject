Console.WriteLine();
Console.WriteLine("Задача 47\n");
// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
// m = 3, n = 4.
void Zadacha47()
{   double[,] rect = new double[3, 4];
   
    void FillRectangl(double[,] rect)
    {   
        for (int i = 0; i < rect.GetLength(0); i++)
        {
            for (int j = 0; j < rect.GetLength(1); j++)
            {
                rect[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }           
        }
    }

    void PrintRectangl(double[,] rect)
    {
        for (int i = 0; i < rect.GetLength(0); i++)
        {
            for (int j = 0; j < rect.GetLength(1); j++)
            {
                Console.Write($"{rect[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    FillRectangl(rect);
    PrintRectangl(rect);
}
Zadacha47();

Console.WriteLine();
Console.WriteLine("Задача 50\n");
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указывает, что такого элемента нет.
void Zadacha50()
{
    int[,] items = new int[5, 6];
    int line = 0;
    int column = 0;

    void FillItemsArray(int[,] items)
    {
        for (int i = 0; i < items.GetLength(0); i++)
        {
            for (int j = 0; j < items.GetLength(1); j++)
            {
                items[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintPositionItems(int[,] items)
    {
        for (int i = 0; i < items.GetLength(0); i++)
        {
            for (int j = 0; j < items.GetLength(1); j++)
            {
                Console.Write($"{items[i, j]} ");
            }
            Console.WriteLine();
        }
        if (line > items.GetLength(0) || column > items.GetLength(1))
        {
            Console.WriteLine("Такого элемента в массиве нет");
        }
        else
        {
            Console.WriteLine($"Значение позиции равно {items[line - 1, column - 1]}");
        }
    }

    Console.Write($"Введите позицию строки массива: ");
    line = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите позицию столбца массива: ");
    column = Convert.ToInt32(Console.ReadLine());
    FillItemsArray(items);
    PrintPositionItems(items);
}
Zadacha50();

Console.WriteLine();
Console.WriteLine("Задача 52\n");
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Random random = new Random();
    int[,] solid = new int[3, 4];

    void FillArray(int[,] solid)
    {
        for (int i = 0; i < solid.GetLength(0); i++)
        {
            for (int j = 0; j < solid.GetLength(1); j++)
            {
                solid[i, j] = new Random().Next(0, 10);
                Console.Write($"{solid[i, j]}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
   
        for (int j = 0; j < solid.GetLength(1); j++)
        {   
            double average = 0;
                           
            for (int i = 0; i < solid.GetLength(0); i++)
            {
                average += solid[i, j];
                          
            }
            Console.Write($"{average / solid.GetLength(0)}; ");  
                       
        }

    }
    FillArray(solid);

}
Zadacha52();

