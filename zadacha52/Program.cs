// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, columns];

CreateArray(array);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avg = 0;
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        avg = (avg + array[i , j]);
    }
    avg /= rows;
    Console.Write(avg + " | ");
}
Console.WriteLine();

void CreateArray(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintArray(int [,] numbers)
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