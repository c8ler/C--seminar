// нахождение длины отрезка между точками A и B
Console.WriteLine("Введите ккординату x1 точки A:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ккординату y1 точки A:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ккординату x2 точки B:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ккординату y2 точки B:");
int y2 = Convert.ToInt32(Console.ReadLine());
var dlina = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine("Длина отрезка равна " + string.Format("{0:N2}", dlina));