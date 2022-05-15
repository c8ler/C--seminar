int number = new Random().Next(10, 99);
Console.WriteLine($"Number = {number}");
int maxNum = FindMaxNumber (number);
Console.WriteLine($"Max = {maxNum}");
int FindMaxNumber (int num)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}