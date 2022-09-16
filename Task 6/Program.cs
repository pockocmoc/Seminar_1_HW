Console.WriteLine("Программа, принимает на вход число и выдаёт, является ли оно чётным.");
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.Write($"Число {num} является чётным!");

}
else
{
    Console.Write($"Число {num} является нечётным!");

}