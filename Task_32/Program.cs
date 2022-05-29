/* Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

Console.Clear();
Console.Write("Введите массив через пробелы: ");

int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + " ");
}