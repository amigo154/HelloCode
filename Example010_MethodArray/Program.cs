﻿int [] array = { 1, 12, 31, 4, 15, 18, 16, 17, 18 };

int n = array.Length;       // возвращает длину массива (количество элементов)
int find = 18;   // элемент массива со значением ...

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;                    // прервать алгоритм на этом месте
    }
    index++;               // index = index + 1
    
}