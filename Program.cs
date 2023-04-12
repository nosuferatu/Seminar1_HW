// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.Clear();

// Console.WriteLine("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberA > numberB)
// {
//     Console.WriteLine($"max = {numberA}");
//     Console.WriteLine($"min = {numberB}");
// }
// else if (numberA == numberB)
// {
//     Console.WriteLine("Число A равно числу B");
// }
// else
// {
//     Console.WriteLine($"max = {numberB}");
//     Console.WriteLine($"min = {numberA}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Например:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine($"max = {numberA}");
    }
    else
    {
        Console.WriteLine($"max = {numberC}");
    }
}
else if (numberB > numberC)
{
    Console.WriteLine($"max = {numberB}");
}
else
{
    Console.WriteLine($"max = {numberC}");
}