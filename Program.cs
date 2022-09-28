//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//int[,] table = new int[3, 4];
//FillArrayRandom(table);
//PrintArray(table);
//SortToLower(table);
//Console.WriteLine();
//PrintArray(table);

//void FillArrayRandom(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
  //  {
   //     for (int j = 0; j < array.GetLength(1); j++)
    //    {
    //        array[i, j] = new Random().Next(1, 10);
    //    }
  //  }
//}

//void SortToLower(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
    //{
      //  for (int j = 0; j < array.GetLength(1); j++)
      //  {
        //    for (int k = 0; k < array.GetLength(1) - 1; k++)
          //  {
            //    if (array[i, k] < array[i, k + 1])
            //    {
              //      int temp = array[i, k + 1];
                //    array[i, k + 1] = array[i, k];
                  //  array[i, k] = temp;
              //  }
          //  }
      //  }
   // }
//}

//void PrintArray(int[,] array)
//{
  //  for (int i = 0; i < array.GetLength(0); i++)
    //{
      //  for (int j = 0; j < array.GetLength(1); j++)
      //  {
        //    Console.Write($"{array[i, j]} ");
        //}
       // Console.WriteLine();
   // }
//}

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//int[,] table = new int[4, 4];
//FillArrayRandom(table);
//PrintArray(table);
//Console.WriteLine();
//NumberRowMinSumElements(table);

//void NumberRowMinSumElements(int[,] array)
//{
  //  int minRow = 0;
  //  int minSumRow = 0;
 //   int sumRow = 0;
 //   for (int i = 0; i < table.GetLength(1); i++)
 //   {
 //       minRow += table[0, i];
//    }
//    for (int i = 0; i < table.GetLength(0); i++)
//    {
//        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//        if (sumRow < minRow)
//        {
//            minRow = sumRow;
//            minSumRow = i;
//        }
//        sumRow = 0;
//    }
//    Console.Write($"{minSumRow + 1} строка");
//}

//void PrintArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write($"{array[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//}

//void FillArrayRandom(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
 //       {
 //           array[i, j] = new Random().Next(1, 10);
 //       }
 //   }
//}
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
 
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
