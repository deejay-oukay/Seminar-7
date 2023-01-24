// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];
double[] average = new double[array.GetLength(1)];
Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
            Console.Write(array[i,j]+" ");
            average[j] += array[i,j];
        }
        Console.WriteLine();
}

for (int i = 0; i < average.Length; i++)
    average[i] = Math.Round(average[i] / array.GetLength(0),1);

Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ",average)}.");