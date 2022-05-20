// вывод условий диапазона для необходимой четверти

Console.WriteLine("Введите номер четверти от 1 до 4:");
int chetv = Convert.ToInt32(Console.ReadLine());
if (chetv == 1) Console.WriteLine("x > 0, y > 0");
else if (chetv == 2) Console.WriteLine("x < 0, y > 0");
else if (chetv == 3) Console.WriteLine("x < 0, y < 0");
else if (chetv == 4) Console.WriteLine("x > 0, y < 0");
else Console.WriteLine("Неверное значение");