//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Задайте двумерный массив.Найдите элементы,у которых оба индекса нечетные,
//и замените эти элементы на их квадраты
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Avarage(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
    Console.WriteLine();
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

void Avarage(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa  = 0;
       double n = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa += array[i, j];
            n = summa / array.GetLength(0);
        }
        Console.Write($"{n} ,  ");
    }

}




