// Задать двумерный массив. Найти сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rows = InputInt("Введите число строк: ");
int columns = InputInt("Введите число столбцов: ");
int sum = 0;
int[,] array = FillArray(rows, columns, 1, 9);

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
            if (i == j)
                sum += array[i, j];
        }
    return array;
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

PrintArray();
Console.WriteLine("Сумма элементов главной диагонали: "+sum);