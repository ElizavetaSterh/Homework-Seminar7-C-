// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i,j],2)}\t", -5);
        }
        Console.WriteLine();
    }
}

double[,] GetInput2DArray(int rows, int colums, int startValue, int finishValue)
{
    
    double[,] array = new double [rows, colums];
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble() * (finishValue - startValue) + startValue;
        }
    }
    return array;
}

int GetInput (string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов в массиве: ");
double[,]massiv = GetInput2DArray (m, n, 1, 100);
Print2DArray(massiv);
