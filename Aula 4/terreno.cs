//Terreno
using static System.Console;

double comp, larg, area, preco;


System.Console.WriteLine("Digite o comprimento do terreno: ");
comp = double.Parse(ReadLine());
System.Console.WriteLine("Digite a largura do terreno: ");
larg = double.Parse(ReadLine());
area = comp*larg;
System.Console.WriteLine($"a área do terreno é {area}");
System.Console.WriteLine("Digite o valor do m² do terreno: ");
preco = double.Parse(ReadLine());
System.Console.WriteLine($"O valor do terreno é {area*preco}");