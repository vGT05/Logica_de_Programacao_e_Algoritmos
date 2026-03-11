using static System.Console;

//declaração de um dicionário
Dictionary<string, int> pessoas = new Dictionary<string, int>()
{
    {"João", 20},
    {"Maria", 30},
    {"Pedro", 40}
};

//adicionando dados ao dicionário
pessoas.Add("Clodoaldo", 54);
WriteLine($"Tamanho = {pessoas.Count()}");
WriteLine(pessoas["Clodoaldo"]);
pessoas.Remove("Clodoaldo");
WriteLine($"Tamanho = {pessoas.Count()}");