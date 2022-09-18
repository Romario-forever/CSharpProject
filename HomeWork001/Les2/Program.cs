Console.WriteLine("Введите два числа: ");
int a, b;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a + " > " + b);
}
else if (b > a)
{
    Console.WriteLine(b + " > " + a);
}
else
{
    Console.WriteLine(b + " = " + a);
}
