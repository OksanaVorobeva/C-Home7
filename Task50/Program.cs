//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.WriteLine("Введите строку ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Check(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 20);
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void Check(int[,] array)
{


if (pos1 < 0 || pos1 > array.GetLength(0) - 1 || pos2 < 0 || pos2 > array.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
}
 
}

