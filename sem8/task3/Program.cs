//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] MatrixFirstArray()
{
    Random rnd = new Random();
    int[,] array = new int[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

int[,] MatrixSecondArray()
{
    Random rnd = new Random();
    int[,] array = new int[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array)
{
    //Console.WriteLine(msg);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] MatrixResultArray(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int [secondArray.GetLength(0), firstArray.GetLength(0)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray[i,j] += firstArray[i,k] * secondArray[k,j];
            }
        }
    }
    return resultArray;
}

int[,] matrixFirst = MatrixFirstArray();
PrintArray(matrixFirst);
Console.WriteLine();
int[,] matrixSecond = MatrixSecondArray();
PrintArray(matrixSecond);
Console.WriteLine();
int[,] matrixResult = MatrixResultArray(matrixFirst, matrixSecond);
PrintArray(matrixResult);
