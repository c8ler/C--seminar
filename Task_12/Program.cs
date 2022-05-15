// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деление.
 

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 % num2 == 0) Console.WriteLine("Кратно");
else
{
    int ostatok = num1 % num2;
    Console.WriteLine($"Не кратно, остаток {ostatok}");
}