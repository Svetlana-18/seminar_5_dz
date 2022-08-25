// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArrayRndInt(int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(4, 7)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"]");
}

int CountElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;

}
int[] arr = CreateArrayRndInt(100, 1000);
PrintArray(arr);
int counts = CountElem(arr);
Console.WriteLine($"Количество четных чисел в массиве: {counts}");
