/*
Задача 38.
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/
float[] generateRandomArray(int length, int start, int finish)
{
    float[] resultArray = new float[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(start, finish + 1);
    }
    return resultArray;
}
float MinNumberInArray(float[] array)
{
    float min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
float MaxNumberInArray(float[] array)
{
    float max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
void printArray(float[] array)
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
float[] array = generateRandomArray(5, -10, 10);
printArray(array);
float min = MinNumberInArray(array);
float max = MaxNumberInArray(array);
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) числами массива равна {max-min}");
