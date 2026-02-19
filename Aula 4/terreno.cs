//Terreno
using static System.Console;

double comp, larg, area, preco;


System.Console.WriteLine("Digite o comprimento do terreno: ");//entrada de dados
comp = double.Parse(ReadLine());

System.Console.WriteLine("Digite a largura do terreno: ");//entrada de dados
larg = double.Parse(ReadLine());

area = comp*larg;//processamento
System.Console.WriteLine($"a área do terreno é {area}");//saida

System.Console.WriteLine("Digite o valor do m² do terreno: ");//entrada
preco = double.Parse(ReadLine());

System.Console.WriteLine($"O valor do terreno é {area*preco}");// processamento + saida