// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Task_1()
{
    int rows = 3;
    int culumns = 4;
    int[,] numbers = new int[rows, culumns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("");
    RegulateArray(numbers);
    PrintArray(numbers);
    
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

void RegulateArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int culumns = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
      
        for(int j = 0; j < culumns - 1; j++)
        {

            for(int a = 0 ; a < culumns - 1; a++)
            {
                if (numbers[i, a] > numbers[i, a + 1])
                {
                    (numbers[i, a], numbers[i, a + 1]) = (numbers[i, a + 1], numbers[i, a]);
                }
            
            }
   
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
}
Task_1();
