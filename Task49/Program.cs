// Задайте двумерный массив. Найти элементы, у которых оба индекса чётные, и заменчить эти элементы на их квадраты
// Пример изначального массива
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Пример нового массива
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int rows = InputInt("Введите число строк: ");
int columns = InputInt("Введите число столбцов: ");
int[,] array = FillArray(4, 3, 1, 10);

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
            array[i, j] = rnd.Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

void ChangeArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (IsEven(i) && IsEven(j))
                array[i,j] *= array[i,j];
}

bool IsEven(int value)
{
    if ((value % 2) == 0)
        return true;
    return false;
}

PrintArray("Оригинальный массив:");
ChangeArray();
PrintArray("Изменённый массив:");
