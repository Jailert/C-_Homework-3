// Найти кубы чисел от 1 до N

void CubeNumber(int a)
{  double i = 1;

    while (i <= a)
    {
        Console.WriteLine($"{i}^3 = {i * i * i}");
        i++;
    }
}

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine()?? "0");
CubeNumber(N);
  