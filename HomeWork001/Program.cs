Console.WriteLine("Введите три числа: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b > c)
{
   max = a;
}

if (b > a > c)
{
    max = b;
}
else (max = c);

Console.WriteLine("наибольшее число" + max);