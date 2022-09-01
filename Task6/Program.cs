// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void fillArray(int[] array, int min, int max)
{   
    Random random = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = random.Next(min,max);
    }
}

void printArray(int[] array)
{
    foreach(int element in array)
        Console.Write($" {element} ");
    Console.WriteLine();
}
int[] array = new int[8];
fillArray(array,0,2);
Console.WriteLine("Array: ");
printArray(array);

