// Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] array, int min, int max)
{   
    Random random = new Random();
    for (int i = 0; i < 12; i++)
    {
        array[i] = random.Next(min,max);
    }
}

int SumPos(int [] array)
{
    int result = 0;
    for (int i = 0; i < 12; i++)
    {
        if (array[i] > 0) result = result + array[i];
    }
    return result;
}

int SumNeg(int [] array)
{
    int res = 0;
    for (int i = 0; i < 12; i++)
    {
        if (array[i] < 0) res = res + array[i];
    }
    return res;
}

void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($" {element} ");
    Console.WriteLine();
}
int[] array = new int[12];
FillArray(array,-9,9);
PrintArray(array);
int x = SumPos(array);
int y = SumNeg(array);
Console.Write($"Sum positive: {x}  Sum negative: {y}");