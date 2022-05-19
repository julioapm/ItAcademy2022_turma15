using System.Net.Http.Json;
public static class ViaCepConsumidor
{
    public const string URI_BASE = "https://viacep.com.br/ws";
    private static readonly HttpClient client = new HttpClient();

    public static Task<HttpResponseMessage> Consultar(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        return client.GetAsync(uri);
    }

    public static async Task<string> ConsultarV2(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        var resultado = await client.GetAsync(uri);
        if (!resultado.IsSuccessStatusCode)
        {
            throw new Exception("Falha de consultao ao ViaCep");
        }
        return await resultado.Content.ReadAsStringAsync();
    }

    public static async Task<ViaCep?> ConsultarV3(string cep)
    {
        var uri = $"{URI_BASE}/{cep}/json";
        var resultado = await client.GetAsync(uri);
        if (!resultado.IsSuccessStatusCode)
        {
            throw new Exception("Falha de consultao ao ViaCep");
        }
        var dados = await resultado.Content.ReadFromJsonAsync<ViaCep>();
        if (dados is not null && dados.Erro is null) return dados;
        return null;
    }
}

public class ViaCep
{
    public string? Erro {get;set;}
    public string? Cep { get; set; }
    public string? Logradouro { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Localidade { get; set; }
    public string? Uf { get; set; }
    public override string ToString()
    {
        return $"{Cep}, {Logradouro}, {Complemento}, {Bairro}, {Localidade}, {Uf}";
    }
}