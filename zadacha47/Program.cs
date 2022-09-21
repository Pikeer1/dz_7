//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[rows, columns];

CreateArray(array);
PrintArray(array);

void CreateArray(double [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i,j] + " ");
        }
        Console.WriteLine(" ");
    }
}