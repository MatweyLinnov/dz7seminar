int[,] CreateArray(int n = 3, int m = 4)
{
    int[,] array = new int[m, n];
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

int IputNum(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

int n = IputNum("Введите индекс строки: ");
int m = IputNum("Введите индекст столбца: ");

int[,] Result(int[,] array)
{
    if (n < array.GetLength(0) && m < array.GetLength(1))
    {
        System.Console.WriteLine();
        System.Console.Write("Искомое число: ");
        System.Console.Write(array[n - 1, m - 1]);

    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"По строке {n} и по столбцу {m} такого числа в массиве нет");
    }
    return array;
}

int[,] baseArray = CreateArray();
PrintArray(baseArray, "Баззовый массив");
int[,] resultArray = Result(baseArray);

