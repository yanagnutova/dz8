//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

//1 4 7 2
//5 9 2 3
//8 4 2 4

//7 4 2 1
//9 5 3 2
//8 4 4 2

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

int[,] FindMin(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array [i,z] < array [i, z + 1])
                {
                    temp = array[i,z];
                    array [i,z] = array [i, z + 1];
                    array [i, z + 1] = temp;
                }
                temp ++;
            
            }
        }
    }
    return array;
}

int[,] array = CreateNumbersArray();
PrintArray(array, "Исходный массив");
int[,] modif = FindMin(array);
PrintArray(modif, "Измененный массив");
