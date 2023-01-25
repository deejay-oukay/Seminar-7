// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[4, 3];

int InputInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void FillAndPrintArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = rnd.Next(-9,10);
                Console.Write(array[i,j]+" ");
            }
            Console.WriteLine();
    }
}

void SearchByIndexes(int x, int y)
{
    if (
        (x < array.GetLength(0))
        &&
        (y < array.GetLength(1))
        &&
        (x >= 0)
        &&
        (y >= 0)
    )
        Console.WriteLine($"Значение элемента с индексами [{x},{y}] = {array[x,y]}");
    else
        Console.WriteLine($"Элемента с индексами [{x},{y}] в массиве нет");
}

void SearchNyNumber(int number)
{
    if (
        (number > (array.GetLength(0)*array.GetLength(1)))
        ||
        (number < 1)
    )
        Console.WriteLine($"Элемента с номером {number} в массиве нет");
    else
    {
        Console.Write($"Значение элемента с номером {number} = ");
        //уменьшаем на 1, так как фактическая нумерация ведётся с 0, а не с 1
        number--;
        Console.WriteLine(array[number / array.GetLength(1),number % array.GetLength(1)]);
    }
}

FillAndPrintArray();

SearchByIndexes(
    InputInt("Введите индекс по оси X, начиная с 0: "),
    InputInt("Введите индекс по оси Y, начиная с 0: ")
);
SearchNyNumber(InputInt("Введите номер элемента, начиная с 1: "));