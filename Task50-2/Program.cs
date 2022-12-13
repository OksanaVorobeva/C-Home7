//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
//и возвращает позицию этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
  bool check =false;
Find(array);
{
       if (check==false)
                {
                   Console.WriteLine("Такого числа в массиве нет");
                    
                }
}


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

void Find(int[,] array)
{
    int pos1 = 0;
    int pos2 = 0;

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (number > 0)
            {
                if (array[i, j] == number)
                {
                    
                    pos1 = i;
                    pos2 = j;
                    Console.Write($"Позиция элемента {number} в массиве {pos1},{pos2} ,");
                    check=true;

                }
                //if (check==false)
                //{
                  // Console.WriteLine("false");
                //    
                //}
                
            }
        }


