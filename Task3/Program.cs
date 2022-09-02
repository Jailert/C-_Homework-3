// Подсчитать сумму цифр в числе

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine()?? "0");
int sum = 0;
   
    for (int i = 0; N > 0; i++)
    {
        sum = sum + N % 10;
        N = N /10 ;   
    }

 Console.WriteLine($"Digit sum = {sum}");