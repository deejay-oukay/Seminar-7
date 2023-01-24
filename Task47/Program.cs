// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3, n = 4;
double[,] array = new double[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(rnd.NextDouble() + rnd.Next(-9,10),1);
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
}
