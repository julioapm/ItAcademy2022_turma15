Pessoa p1 = new Pessoa("John Doe", 22);
Console.WriteLine(p1.Nome);
p1.Idade = 23;
Console.WriteLine(p1.Idade);
Venda v1 = new Venda {Cliente = p1, EntregaRealizada = false};
//v1.Cliente = null; //não pode
Console.WriteLine(v1.Cliente.Nome);
v1.EntregaRealizada = true;
Console.WriteLine(v1.EntregaRealizada);
Produto prod1 = new Produto("abc123", "Caderno", 12.99M);
Produto prod2 = new Produto("xyz123", "Caneta", 3.50M);
v1.AdicionarItem(prod1);
v1.AdicionarItem(prod2,2);
Console.WriteLine(v1.Total);
for(int i=0; i<v1.QuantidadeProdutos; i++)
{
    Console.WriteLine(v1[i].Descricao);
}