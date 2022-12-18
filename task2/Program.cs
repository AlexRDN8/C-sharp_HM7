// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] array = CreateRandom2dArray(3, 4);
Print2DArray(array);
Console.WriteLine("введите индекс строки нужного элемента");
int position1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите индекс столбца нужного элемента");
int position2 = int.Parse(Console.ReadLine());

if (position1 < array.GetLength(0) && position2 < array.GetLength(1)) 
{
    Console.WriteLine($"На данной позиции находится элемент: {array[position1, position2]}");
}
else 
{
    Console.WriteLine($"числа на позиции[{position1},{position2}] в массиве нет");
}

int [,] CreateRandom2dArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();
    int[,] array = new int[countOfRows, countOfColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(-10, 11);
        }
    }
    return array;
}

void Print2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
