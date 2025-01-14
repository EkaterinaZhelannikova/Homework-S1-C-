﻿//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
///27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Console.Clear();
Console.Write("Введите размерность 1: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность 2: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность 3: ");
int z = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintArray(array3D);


void PrintArray (int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write( $"{array3D[i, j, k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] newArray = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int  number;
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        newArray[i] = new Random().Next(10, 100);
        number = newArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (newArray[i] == newArray[j])
                {
                    newArray[i] = new Random().Next(10, 100);
                    j = 0;
                    number = newArray[i];
                }
                number = newArray[i];
            }
        }
    }
    int counter = 0; 
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = newArray[counter++];
            }
        }
    }
}