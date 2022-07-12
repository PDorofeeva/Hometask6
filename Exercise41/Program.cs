/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3


int[] array = Console.ReadLine().Split(new char[]{' '},
StringSplitOptions.RemoveEmptyEntries).Select(i=>int.Parse(i)).ToArray<int>();
int count = 0;
for (int i = 0; i<array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во положительных чисел: {count}");
*/

Console.WriteLine("Кол-во вводимых чисел:");
int Length = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < Length; i++)
{
    Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());
        if (number>0)
        {
            count++;
        }
}
Console.WriteLine($"Кол-во положительных чисел: {count}");

