// вводим число N и выводим N чисел от 1 до N ^ 2

Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count < n)
{
    Console.Write($"{count * count}, ");
    count++;
}
Console.Write($"{count * count}");