//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [5, 5];

CreateArray(array);
PrintArray(array);

if (row > array.GetLength(0) || column > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Элемент в {row} строке и {column} столбце = {array[row-1, column-1]}");
}

void CreateArray(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 21);
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