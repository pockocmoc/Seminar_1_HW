Console.WriteLine("Программа, принимает на вход число и выдаёт, является ли оно чётным.");
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
Console.Write("Число ");
Console.Write(num);
Console.Write(" является чётным!");
}
else
{
Console.Write("Число ");
Console.Write(num);
Console.Write(" является нечётным!");
}