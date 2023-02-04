int[,] CreateArray(int n = 3, int m = 4)
{
    int[,] array = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
    }
}

int[,] QWE(int[,] array)
{
    //System.Console.Write("=====================================================");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double res = sum / array.GetLength(0);
        System.Console.Write($"{res}" + " | ");
    }
    return array;
}

int[,] baseArray = CreateArray();
PrintArray(baseArray, "Баззовый массив");
System.Console.WriteLine();
int[,] Base = QWE(baseArray);
