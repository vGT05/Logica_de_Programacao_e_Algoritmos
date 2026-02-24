
using static System.Console;

int a, b, c;
Write("Digite o primeiro valor: ");
a = int.Parse(ReadLine());
Write("Digite o segundo valor: ");
b = int.Parse(ReadLine());
Write("Digite o terceiro valor: ");
c = int.Parse(ReadLine());

bool a1 = a == c;
bool a2 = b != a;
bool a3 = b > c;
bool a4 = a <= c;

WriteLine($"1°: O primeiro valor é igual ao terceiro valor? {a1}\n");
WriteLine($"2°: O segundo valor é diferente do primeiro valor? {a2}\n");
WriteLine($"3°: O segundo valor é maior que o terceiro valor? {a3}\n");
WriteLine($"4°: O primeiro valor é menor ou igual que o terceiro valor? {a4}\n");

string pr = a1 & a3 ? "São verdadeiras":"São falsas";
string sg = a2 | a4 ? "Uma das respostas é verdadeira":"Nenhuma das respostas é verdadeira";
string tr = !a1 == true ? "A negação é verdadeira":"A negação é falsa";

WriteLine($"A primeira e a terceira pergunta são verdadeiras? {pr}\n");
WriteLine($"A segunda ou a quarta pergunta são verdadeiras? {sg}\n");
WriteLine($"A negação da primeira pergunta é verdadeira? {tr}\n");