Pessoa p1 = new Pessoa("John Doe", 22);
Console.WriteLine(p1.Nome);
p1.Idade = 23;
Console.WriteLine(p1.Idade);
Venda v1 = new Venda {Cliente = p1, EntregaRealizada = false};
//v1.Cliente = null; //não pode
Console.WriteLine(v1.Cliente.Nome);
v1.EntregaRealizada = true;
Console.WriteLine(v1.EntregaRealizada);