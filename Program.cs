Console.WriteLine("Faça o calculo da área");

Console.Write("A =");
Console.Write(" N(3,14)");
Console.WriteLine(" . raio²");

Console.WriteLine("coloque o valor do raio para ser multiplicado por N");
double raio = double.Parse (Console.ReadLine());
double r = Math.Pow(raio,2);

double PI = 3.14159;

double mult = r * PI;

Console.WriteLine($"A area do circulo é: {mult}");