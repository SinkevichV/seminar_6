/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int[] RandomArray(int arraySize)
{

    int[] array = new int[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arraySize; i++)
        array[i] = rnd.Next(-10, 10);

    return array;

}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();

}

void PositivNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + (i + 1) / (i + 1);
        }

    }
    Console.Write($"в данном массиве больше ноля {result} элементов ");
}

Console.WriteLine($"Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = RandomArray(arraySize);
PrintArray(arr);
PositivNumber(arr);