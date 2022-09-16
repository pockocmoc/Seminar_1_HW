// int a = 5, b = 7;

// int max = a;

// if (b > max) max = b;
// Console.WriteLine(max);

Console.WriteLine("Программа, принимает на вход два числа и выдаёт, большое из них.");
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;

Console.Write($"Число {max} большее из двух!");


