//задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2

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