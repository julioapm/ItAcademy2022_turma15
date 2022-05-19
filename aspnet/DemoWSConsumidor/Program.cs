try
{
    Console.WriteLine("Consumindo ViaCep...");
    var resultado = await ViaCepConsumidor.Consultar("01001000");
    Console.WriteLine($"Sucesso: {resultado.IsSuccessStatusCode}");
    Console.WriteLine($"Código Status: {resultado.StatusCode}");
    var dados = await resultado.Content.ReadAsStringAsync();
    Console.WriteLine(dados);

    Console.WriteLine("Consumindo ViaCep V2...");
    var resultado2 = await ViaCepConsumidor.ConsultarV2("01001000");
    Console.WriteLine(resultado2);

    Console.WriteLine("Consumindo ViaCep V3...");
    var resultado3 = await ViaCepConsumidor.ConsultarV3("90040190");
    Console.WriteLine(resultado3);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
