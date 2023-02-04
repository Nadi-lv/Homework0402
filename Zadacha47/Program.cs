double[,] GenerateArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();

       for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.NextDouble()*100;


    return array;
}

void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j],2) + "   " );
        Console.WriteLine();
    }
}
var array = GenerateArray(3,4);
PrintArray2D(array);

