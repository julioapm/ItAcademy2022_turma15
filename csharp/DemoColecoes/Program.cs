List<int> numeros = new List<int>();
numeros.Add(0);
numeros.Add(1);
numeros.Add(2);
foreach (var item in numeros)
{
    Console.WriteLine(item);
}
Console.WriteLine(numeros[2]);

Dictionary<string,string> estados = new Dictionary<string, string>();
estados.Add("RS","Rio Grande do Sul");
estados.Add("SC", "Santa Catarina");
estados.Add("PR","Paraná");
Console.WriteLine(estados["RS"]);
foreach (var item in estados.Values)
{
    Console.WriteLine(item);
}
foreach (var item in estados)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}