// Задать двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int m = 3, n = 4;
int[,] array = new int[m, n];
Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(-99,100);
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
}
