// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int na = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int nb = Convert.ToInt32(Console.ReadLine());

if(na > nb)
    Console.WriteLine("Первое число больше второго");

if(na < nb)
    Console.WriteLine("Второе число больше первого");
