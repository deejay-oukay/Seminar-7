// Задайте двумерный массив размером m×n, каждый элемент которого находится по формуле: А[m,n] = m+ n
// Вывести полученный массив на экран
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int m = InputInt("Введите количество строк (m): ");
int n = InputInt("Введите количество строк (n): ");

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        {
            array[i,j] = i+j;
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
}
