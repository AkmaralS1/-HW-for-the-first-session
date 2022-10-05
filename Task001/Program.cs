// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int na = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int nb = Convert.ToInt32(Console.ReadLine());
int maxi = na;
if (maxi < nb)
    maxi = nb;

Console.WriteLine("maxi");