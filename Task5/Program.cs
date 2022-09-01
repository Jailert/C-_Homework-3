// Показать кубы чисел, заканчивающихся на четную цифру

void CubeNumber(int a)
{  
    for (double i = 2; i <= a; i++)
    {
        Console.WriteLine($"{i}^3 = {i * i * i}");
        i++;
        
    }
}

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine()?? "0");
CubeNumber(N);
