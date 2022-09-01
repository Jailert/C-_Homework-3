// Написать программу вычисления произведения чисел от 1 до N

void Multiplication(int a)
{  
   
    for (int i = 2; i <= a; i++)
    {
        for (int j = 2; j<=a; j++)
        {
            Console.WriteLine($"{i} x {j} = {i*j}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine()?? "0");
Multiplication(N);