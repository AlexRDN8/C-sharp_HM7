// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,]array = new int[3,4]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

GetMeanOfColumns (array);

void GetMeanOfColumns (int[,] array)
{    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        double result = sum / array.GetLength(0);
        Console.WriteLine(result);
    }
    
}
