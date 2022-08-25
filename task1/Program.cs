// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива:  ");
int lenght = Convert.ToInt32(Console.ReadLine());

if (lenght == 0 || lenght < 0)
{
    Console.Write("Вы ввели недопустимое значение");
    return;
}

int[] RandArray(int len)
{
    int[] arrays = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < arrays.Length; i++)
    {
        arrays[i] = rnd.Next(0, 100);

    }
    return arrays;
}

void PrintArray(int[] res1)
{
    Console.Write("[");
    for (int i = 0; i < res1.Length - 1; i++)
    {
        Console.Write($"{res1[i]}, ");

    }
    Console.Write($"{res1[res1.Length - 1]}]");
}

int SumElem(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i++)
    {
        sum += array[i];
        i++;
    }
    return sum;
}
int[] res = RandArray(lenght);
PrintArray(res);


int sumelem = SumElem(res);
Console.WriteLine($"   Сумма элементов, стоящих на нечётных позициях (индексах) равна: {sumelem}");
