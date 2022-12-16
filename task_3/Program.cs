// Заполните спирально массив 4 на 4 числами от 1 до 16.

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Task_3()
{
    int rows = 4;
    int columns = 4;

    int indexRow = 0;
    int indexColumn = 0;

    int biasRow = 0;
    int biasColumn = 1; 

    int steps = columns;
    int turn = 0; // (Кол-во поворотов)
    int[,] numbers = new int[rows, columns];

    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[indexRow, indexColumn] = i + 1;
        steps --;
        if(steps == 0)
        {
            steps = columns - 1 - turn/2;
            int temp = biasRow;

            biasRow = biasColumn;
            biasColumn = -temp;

            turn ++;
        }
        indexRow += biasRow;
        indexColumn += biasColumn;


    }
    PrintArray(numbers);
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "   ");
        }
        Console.WriteLine(""); 
    }
}
Task_3();

