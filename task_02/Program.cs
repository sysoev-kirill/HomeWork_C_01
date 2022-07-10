// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Input first num: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second num: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first > second)
{
   Console.WriteLine($"max {first} min {second}");
}
else
   Console.WriteLine($"max {second} min {first}");