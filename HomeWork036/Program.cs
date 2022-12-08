/*
Задача 36.
Задайте одномерный массив, заполненный числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] generateRandomArray(int length, int start, int finish)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(start, finish + 1);
    }
    return resultArray;
}

int CountPositiveNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] array = generateRandomArray(4, -99, 99);
printArray(array);
int summ = CountPositiveNumbers(array);
Console.WriteLine($"Сумма элементов на нечетных позициях равна {summ}");
