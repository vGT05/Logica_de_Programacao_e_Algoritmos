using System.Security.Cryptography;
using static System.Console;
//comparador
int a = 5;
int b = 2+3;
bool resultado = a != b;
WriteLine($"O resultado da comparação é: {resultado}");
//comparador ternário
int c = 3;
int d = 5;
string x = c != d ? "pior que é":"né não";
WriteLine($"O resultado? {x}");
//comparação lógica
bool y = true;
bool z = true;
bool logico = z | y;
WriteLine($"O resultado da comparação é {!logico}"); //OU( | ): se um dos valores for verdadeiro então a saida dará como verdadeira
                                                    //E( & ): se ambos os valores forem verdadeiros então a saida dará como verdadeira
                                                    //NEG( ! ): inverte o valor do resultado(True passa a ser False e vice versa)