using static System.Console;

double a, b, c, areaQ, areaTri, AreaTrap;

WriteLine("Digite a medida A: ");
a = double.Parse(ReadLine());
WriteLine("Digite a medida B: ");
b = double.Parse(ReadLine());
WriteLine("Digite a medida C: ");
c = double.Parse(ReadLine());

areaQ = a*a;
areaTri = (a*b)/2;
AreaTrap = ((a+b)*c)/2;

WriteLine($"A área do quadrado é {areaQ:F4}");
WriteLine($"A área do triangulo é {areaTri:F4}");
WriteLine($"A área do trapézio é {AreaTrap:F4}");