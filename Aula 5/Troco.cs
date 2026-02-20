using static System.Console;

double price, quant, money, total;

WriteLine("Digite o valor do produto: ");
price = double.Parse(ReadLine());
WriteLine("Digite a quantidade de produtos: ");
quant = double.Parse(ReadLine());
WriteLine("Digite a quantidade de dinheiro recebido: ");
money = double.Parse(ReadLine());

total = price*quant;

WriteLine($"(O valor a ser devolvido é de: R${money-total})");

