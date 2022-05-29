/* Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */

Console.Clear();
Console.Write("Введите массив через пробелы: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.Write("Введите искомое число: ");
int find = int.Parse(Console.ReadLine());

void FindInArray (int[] arr, int findChislo)
{
    bool flag = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            flag = true;
            break;
        }
    }
    if (flag) Console.WriteLine("Да, число есть");
    else Console.WriteLine("Нет, числа нет");
}

FindInArray(array, find);