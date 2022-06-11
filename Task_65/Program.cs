/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

Console.Clear();
Console.Write("Задайте начальное число M: ");
int mm = int.Parse(Console.ReadLine());
Console.Write("Задайте конечное число N: ");
int nn = int.Parse(Console.ReadLine());

if (mm < nn) NaturalNumber(mm, nn);
else NaturalNumber(nn, mm);

void NaturalNumber(int m, int n)
{
    if (m > n) return;
    NaturalNumber(m, n - 1);
    Console.Write($"{n} ");
}
