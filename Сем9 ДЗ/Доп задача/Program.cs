﻿//Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел 
//(без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа 
//из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива 
//data с учётом информации из массива info.
//входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } info = {2, 3, 3, 1 } 
//выходные данные: 1, 7, 0, 1

Console.Clear();

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int c = -1;
for (int i = 0; i < info.Length; i++)
{
    int bitNum = 0;
    c += info[i];
    int k = c;
    for (int j = 0; j < info[i]; j++)
    {
        bitNum += data[k]* (int)MathF.Pow(2, j);
        k--;
    }
    Console.Write($"{bitNum} ");
}