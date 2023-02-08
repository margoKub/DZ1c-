//задача 2
//


Console.WriteLine("Введите два неодинаковых целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine ($"{a}=max, {b}=min");
}
else
{
    Console.WriteLine ($"{b}=max, {a}=min");
}