// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.

int number = new Random().Next(100, 999);
Console.WriteLine($"Number = {number}");
int withoutSecondDigit = DeleteSecondDigit (number);
Console.WriteLine($"Without second digit = {withoutSecondDigit}");
int DeleteSecondDigit (int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return firstDigit * 10 + thirdDigit;
}
