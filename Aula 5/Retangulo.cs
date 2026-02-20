using static System.Console;

double alt, bas, diag;

WriteLine("Digite o valor da base do retângulo: ");
bas = double.Parse(ReadLine());
WriteLine("Digite o valor da altura do retângulo: ");
alt = double.Parse(ReadLine());
WriteLine($"A área do retângulo é {alt*bas}");
WriteLine($"O perímetro do retângulo é {(alt*2) + (bas*2)}");
WriteLine($"A diagonal do retângulo é {Math.Sqrt((bas*bas) + (alt*alt))}");