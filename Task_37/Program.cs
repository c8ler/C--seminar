/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
ПОКА ДЛЯ 3-Х ЭЛЕМЕНТОВ РАБОТАЕТ НЕ ПРАВИЛЬНО =( */

Console.Clear();
Console.Write("Введите массив через пробелы: ");
int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int FindSize(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 0) size = arr.Length / 2;
    else size = arr.Length / 2 + 1;
    return size;
}
int arrSize = FindSize(array);
int[] newArray = new int[arrSize];

Console.WriteLine("Новый массив ");

void Napolnenie(int[] newArr, int[] oldArr)
{
    if (newArr.Length % 2 == 0)
    {
        for (int i = 0; i < newArr.Length; i++)
        {
            newArr[i] = oldArr[i] * oldArr[oldArr.Length - 1 - i];
            Console.Write(newArr[i] + " ");
        }
    }
    else
    {
        for (int i = 0; i < newArr.Length - 1; i++)
        {
            newArr[i] = oldArr[i] * oldArr[oldArr.Length - 1 - i];
            Console.Write(newArr[i] + " ");
        }
        Console.Write(oldArr[oldArr.Length / 2]);
    }
}
Napolnenie(newArray, array);