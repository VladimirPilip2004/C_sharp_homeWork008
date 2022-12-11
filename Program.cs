//------------------------- Methods -------------------------
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)  // внешний цикл будет проходится по всем строкам
        for (int j = 0; j < colums; j++) // а внутренний по столбцам
            array[i,j] = new Random().Next(minValue, maxValue);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            //Console.Write(array[i,j] + " ");
            {
                if (array[i, j] / 10 == 0)
                    Console.Write($"0{array[i, j]} ");                  
                else
                    Console.Write($"{array[i, j]} ");
            }
        Console.WriteLine();    
    }
    Console.WriteLine();
}

// void SqareMatrixMult(int a1, int a2, int b1, int b2,
//                      int c1, int c2, int d1, int d2)
// {
//     Console.WriteLine("Result of multiplication of two matrixes: ");
//     Console.WriteLine($"|{a1 * c1 + b1 * c2} {a1 * d1 + b1 * d2}|");
//     Console.WriteLine($"|{a2 * c1 + b2 * c2} {a2 * d1 + b2 * d2}|\n");
// } 

// int[,,] Create3dArrayUniqueDigits(int rows, int columns, int depth, int minValue, int maxValue)
// {
//     int[,,] array = new int[rows, columns, depth];
//     bool[] valueMemory = new bool[maxValue + 1];
//     for (int r = 0; r < rows; r++)
//         for (int c = 0; c < columns; c++)
//             for (int d = 0; d < depth; d++)
//             {
//             ReRandom:
//                 int valueNew = new Random().Next(minValue, maxValue + 1);
//                 if (valueMemory[valueNew]) goto ReRandom;
//                 valueMemory[valueNew] = true;
//                 array[r, c, d] = valueNew;
//             }
//     return array;
// }
// void Show3dArray(int[,,] array)
// {
//     for (int r = 0; r < array.GetLength(0); r++)
//         for (int c = 0; c < array.GetLength(1); c++)
//             for (int d = 0; d < array.GetLength(2); d++)
//                 Console.Write($"{array[r, c, d]}({r},{c},{d})\n");
// }

// void FillArray(int[,] array, int n, int m)
// {
//     int row = 0;
//     int col = 0;
//     int x = 1;
//     int y = 0;
//     int count = 0;
//     int visits = m;

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[row, col] = i + 1;
//         if (--visits == 0)
//         {
//             visits = m * (count % 2) + n * ((count + 1) % 2) - (count / 2 - 1) - 2;
//             int temp = x;
//             x = -y;
//             y = temp;
//             count++;
//         }

//         col += x;
//         row += y;
//     }
// }


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// void NewSortString(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// Console.WriteLine();

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Console.WriteLine("Old array");
// Show2dArray(myArray);


// Console.WriteLine("New array");
// NewSortString(myArray);
// Show2dArray(myArray);
// Console.WriteLine();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("My array");
Show2dArray(myArray);

int[] summ = new int[myArray.GetLength(1)];

for (int a = 0; a < myArray.GetLength(0); a++)
{
    for (int b = 0; b < myArray.GetLength(1); b++)
    {
        summ[a] = summ[a] + myArray[a, b];
    }
    Console.WriteLine($"Summ {a + 1} string is: {summ[a]}");
}

int temp;
for (int i = 0; i < summ.Length; i++)
{
    for (int j = 0; j < summ.Length-1; j++)
    {
        if(summ[j]>summ[j+1])
        {
            temp=summ[j+1];
            summ[j+1]=summ[j];
            summ[j]=temp;
        }
    }
}
Console.WriteLine($"Minumal summ of the string is: {summ[0]}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.WriteLine("Matrix: \n");
// Console.WriteLine("|a1 b1| |c1 d1|");
// Console.WriteLine("|a2 b2| |c2 d2|\n");
// Console.Write("Input a1: ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a2: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input c1: ");
// int c1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input c2: ");
// int c2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input d1: ");
// int d1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input d2: ");
// int d2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// SqareMatrixMult(a1, a2, b1, b2, c1, c2, d1, d2);

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Для любых чисел, без проверки на кол-во элементов матрицы с отрезком чисел.
// Console.Write("Input a number of rows: ");
// int inputRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int inputColumns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of depth: ");
// int inputDepth = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,,] myArray = Create3dArrayUniqueDigits(inputRows, inputColumns, inputDepth, min, max);
// Show3dArray(myArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void FillArrayRandom(int[,] array, int n, int m)
// {
//     int row = 0;
//     int col = 0;
//     int x = 1;
//     int y = 0;
//     int count = 0;
//     int visits = m;

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[row, col] = i + 1;
//         if (--visits == 0)
//         {
//             visits = m * (count % 2) + n * ((count + 1) % 2) - (count / 2 - 1) - 2;
//             int temp = x;
//             x = -y;
//             y = temp;
//             count++;
//         }

//         col += x;
//         row += y;
//     }
// }

// Console.Write("Input a number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of colums: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = new int[n, m];

// FillArray(myArray, n, m);
// Show2dArray(myArray);
