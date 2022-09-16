Console.WriteLine("Программа, принимает вход число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите число N, большое или равное 1: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

Console.WriteLine("Чётные числа: ");
for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);


