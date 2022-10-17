Console.WriteLine();
Console.WriteLine("Задача 56\n");
//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов.
void Zadacha56()
{
    Random random = new Random();
    int[,] rectangArray = new int[4, 5];
    FillArray(rectangArray);
    NumMinSumElementsLine(rectangArray);

    void FillArray(int[,] rectangArray)
    {
        for (int i = 0; i < rectangArray.GetLength(0); i++)
        {
            for (int j = 0; j < rectangArray.GetLength(1); j++)
            {
                rectangArray[i, j] = new Random().Next(10, 30);
                Console.Write($"{rectangArray[i, j]}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    void NumMinSumElementsLine(int[,] rectangArray)
    {
        int minLine = 0;
        int minSumLine = 0;
        int sumLine = 0;
        for (int i = 0; i < rectangArray.GetLength(1); i++)
        {
            minLine += rectangArray[0, i];
        }
        for (int i = 0; i < rectangArray.GetLength(0); i++)
        {
            for (int j = 0; j < rectangArray.GetLength(1); j++)
                sumLine += rectangArray[i, j];
            if (sumLine < minLine)
            {
                minLine = sumLine;
                minSumLine = i;
            }
            Console.WriteLine(sumLine);
            sumLine = 0;
        }
        Console.Write($"{minSumLine + 1} строка");
    }
    Console.WriteLine();

}
Zadacha56();

Console.WriteLine();
Console.WriteLine("Задача 58\n");
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void Zadacha58()
{
    Random random = new Random();
    int[,] firstMatrix = new int[3, 3];
    int[,] secondMatrix = new int[3, 3];
    int[,] resultMatrix = new int[3, 3];
    CreateArray1(firstMatrix);
    CreateArray2(secondMatrix);
    MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);


    void CreateArray1(int[,] firstMatrix)
    {
        Console.WriteLine($"Первая матрица: ");
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < firstMatrix.GetLength(1); j++)
            {
                firstMatrix[i, j] = new Random().Next(1, 10);
                Console.Write($"{firstMatrix[i, j]}  ");
            }
            Console.WriteLine();
        }
        
    }

    void CreateArray2(int[,] secondMatrix)
    {
        Console.WriteLine($"Вторая матрица: ");
        for (int i = 0; i < secondMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                secondMatrix[i, j] = new Random().Next(1, 9);
                Console.Write($"{secondMatrix[i, j]}  ");
            }
            Console.WriteLine();
        }
        
    }

    void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
    {
        Console.WriteLine($"Произведение первой и второй матриц:");
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMatrix.GetLength(0); k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                resultMatrix[i, j] = sum;
                Console.Write($"{resultMatrix[i, j]}  ");
            }
            Console.WriteLine();
        }
    }
}
Zadacha58();

Console.WriteLine();
Console.WriteLine("Задача 60\n");
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void Zadacha60()
{
    int[,,] cube = new int[2, 2, 2];
    CreateCube(cube);


    void CreateCube(int[,,] cube)
    {
        Console.WriteLine($"Трехмерный массив : ");
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)

            {
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    cube[i, j, k] = new Random().Next(10, 100);
                    Console.Write($"{cube[i, j, k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }


}
Zadacha60();

