// Написать программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write($"Максимальное число: {num1}");
    Console.Write($" Минимальное число: {num2}");
}

if(num1 < num2)
{
    Console.Write($"Максимальное число: {num2}");
    Console.Write($" Минимальное число: {num1}");
}

if(num1 == num2)
{
    Console.WriteLine("Числа равны");
}