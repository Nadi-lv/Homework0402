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

void Poisk(int[,] array, int m, int n){
    if (m < array.GetLength(0) && n < array.GetLength(1))
         Console.WriteLine($"Искомый элемент массива: {array[m,n]}");
    else 
        Console.WriteLine("Элемента с такими индексами нет");
}

var array = GenerateArray(3,4,0,9);
Console.WriteLine("Сгенерированный массив: ");
PrintArray2D(array);
Console.WriteLine("Введите номер строки:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int n = Convert.ToInt32(Console.ReadLine());
Poisk(array, m,n);
