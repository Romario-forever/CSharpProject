using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("Задача к уроку 4");
            Console.WriteLine();
            /* Есть магазин "Еда". В магазине есть охранник. Охранник ведёт запись всех, 
            кто заходит в магазин. Охранник ведёт запись всех, кто выходит из магазина.
            Зайти и выйти можно в целый час.
            Задача: выяснить в какой промежуток времени было больше всего посетителей.
            Данные вводятся парами: приход-уход
            Максимум 40 покупателей
            Входные данные: 9-12; 10-12; 11-13.
            Ответ: 11-12*/

            void ZadachaForShop()
            {
                int timeWork = 24;
                int[] interval = new int[timeWork];
                FillTimeArray(interval);
                FillBuyers();

            }

            void FillTimeArray(int[] interval)
            {
                Console.WriteLine("Время работы: ");
                for (int i = 0; i < interval.Length; i++)
                    Console.Write((i) + " ");
                Console.WriteLine();
            }

            void FillBuyers()
            {   
                int[] buyers = new int[40];
                Console.WriteLine("Количество покупателей: ");
                for (int j = 9; j <= 12; j++)
                {
                    buyers[j] += 1;
                }
                 for (int k = 10; k <= 12; k++)
                {
                    buyers[k] += 1;
                }
                 for (int m = 11; m <= 13; m++)
                {
                    buyers[m] += 1;
                }
                
                Console.WriteLine(String.Join(' ', buyers));

            }

            ZadachaForShop();



        }

    }
}
