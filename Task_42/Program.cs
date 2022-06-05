// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в разную систему счисления.

bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Введите систему счисления: ");
    int baseNumber = int.Parse(Console.ReadLine());

    DecToOther(number, baseNumber);
    Console.WriteLine();

    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

void DecToOther(int num, int baseN)
{
    if (num == 0) return;
    DecToOther(num / baseN, baseN);
    Console.Write(num % baseN);
}