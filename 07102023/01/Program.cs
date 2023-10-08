// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int min, int max, int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumPositiveNumbers(int[] arr)    
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            result += 1;
        }
    }
    return result;
}


Console.Write("Введите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива: ");
int sizeValue = Convert.ToInt32(Console.ReadLine());

int[] res = CreateArray(minValue, maxValue, sizeValue);
PrintArray(res);

int sumPositiveNumbers = SumPositiveNumbers(res);
Console.Write($" -> {sumPositiveNumbers}");