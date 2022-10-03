// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int rem1;
int n = Convert.ToInt32(Console.ReadLine());
rem1 = n % 2;
    if(rem1 ==0)
Console.WriteLine("{0} is an even integer. \n",n);
    else
Console.WriteLine("{0} is an odd integer. \n",n);    