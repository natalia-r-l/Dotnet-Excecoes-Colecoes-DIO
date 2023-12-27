/*

Dictionary é uma coleção de chave-valor para armazenar valores únicos sem uma ordem específica
O primeiro elemento é a chave, e deve ser única, caso não seja, gerará erro.

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");
// estados.Add("BA", "Bahia"); Caso tente adicionar o mesmo estado novamente, identificado por BA, gerará erro.

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";
Console.WriteLine(estados["SP"]);

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
}

*/