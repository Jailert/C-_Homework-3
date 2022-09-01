// Возведите число А в натуральную степень B используя цикл

Console.WriteLine ("Enter A: ");
double A = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine ("Enter B: ");
double B = double.Parse(Console.ReadLine() ?? "0");   

double i = 1;
double pow = 1;

for (i = 1; i<=B; i++)
{ 
    pow *= A;
    Console.WriteLine($" A^B = {pow}");
}