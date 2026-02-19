//Entrada de dados
using System.Runtime.InteropServices;
using static System.Console;

WriteLine("Escreva o seu nome: ");
string nome = ReadLine();//entrada de dados
WriteLine($"Seu nome é: {nome} :3");//saida de dados

WriteLine("Digite o primeiro numero: ");
double x = double.Parse(ReadLine());//entrada de dados
WriteLine("Digite o segundo numero: ");
double y = double.Parse(ReadLine());//entrada de dados
double soma = x + y;//processamento de dados
WriteLine($"A soma dos dois valores é de: {soma}");//saida de dados