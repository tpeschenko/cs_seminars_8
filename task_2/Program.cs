//  Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

void Task_2()
{
    int rows = 3;
    int culumns = 4;
    int[,] numbers = new int[rows, culumns];

    FillArray(numbers);
    PrintArray(numbers);
    PrintMinSumRow(numbers);
    
}

void FillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < culumns; j++)
        {
            numbers[i, j] = rand.Next(0, 10);
            
        } 
    }
}

void PrintMinSumRow(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    double[] num = new double[3];
    for(int i = 0; i < rows; i++)
    {
        double sum = 0;
        int count = 0; 
        for(int j = 0; j < culumns; j++)
        {
            sum += numbers[i, j];
            count ++;
            
        }
      
    num[i] = sum;
    }
    double numMin = num[0];
    int h = 0; 
    for(int i = 0; i < num.Length; i ++)
    {
        if(num[i] < num[0])
        {
            numMin = num[i];
            h = i;
        } 
    }

    Console.Write($"Сумма строки с наименьшей суммой элементов: {numMin}\nНомер строки: {h}\n");
    Console.Write("Cтрока с наименьшей суммой элементов: ");
    for(int i = h; i == h; i ++)
    {
        for(int j = 0; j < culumns; j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
    }
}


void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < culumns; j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine(""); 
    }
    Console.WriteLine("-------");
}
Task_2();