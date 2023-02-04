int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random random = new Random();

       for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(min, max + 1);


    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "   " );
        Console.WriteLine();
    }
}

void sredneeArifm (int[,] array){
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++){
         for (int i = 0; i < array.GetLength(0); i++){

             result[j] += array[i,j]; 
         
    }
    result[j] = result[j]/array.GetLength(0);
    Console.Write(Math.Round(result[j],2) + "   ");
    }
    
}

var array = GenerateArray(3,4,0,9);
Console.WriteLine("Сгенерированный массив: ");
PrintArray2D(array);
Console.WriteLine("Среднее арифметическое по столбцам:");
sredneeArifm(array);

