//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

int[,] CreateNumbersArray()
{
    Random rnd = new Random();
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, string msg)
{
    Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] FindSummInLines(int[,] array)
{
    int[] summArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        summArray[i] = summ;
    }
    return summArray;
}

int FindMinSumm(int[] array)
{
    int minSum = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (minSum > array[i])
        {
            minSum = array[i];
            index = i;
        }
    }
    return index;
}

    void PrintSummArray(int[] array, string msg)
    {
        Console.WriteLine(msg);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"{array[i]} ");
            Console.WriteLine();
        }
        //Console.WriteLine();
    }


    int[,] array = CreateNumbersArray();
    PrintArray(array, "Исходный массив");
    int[] summ = FindSummInLines(array);
    PrintSummArray(summ, "Промежуточный массив с суммами строк");
    int minSumm = FindMinSumm(summ);
    Console.WriteLine($"{minSumm + 1} - строка с минимальной суммой элементов массива");