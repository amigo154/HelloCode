void FillArray(int[] collection)       // метод который заполняем массив рандомными числами. Void это метод который не возращает значение(поэтому нельзя использовать return)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)    // метод который распечатывает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int [] array = new int[10];   // создай новый массив в котором будет 10 элементов(по умолчанию будет заполнен нулями)

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;   // искусственный прием, если нужного числа в массиве нет, чтобы он не показывал 0. Вывод в программе -1 по сути означает что такого элемента нет
     
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;                     // стопорим, так как найти нужно первый элемент
        }
        index++;
    }
    return position;
}

FillArray(array);
array[4] = 4;  // принудительно закинули 4
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);              // находим порядковый номер элемента массива со значением 4
Console.WriteLine(pos);
