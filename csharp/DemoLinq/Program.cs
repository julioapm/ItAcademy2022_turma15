List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa{Nome="Ana", Casada=true, DataNascimento=new DateTime(1980,3,14)},
    new Pessoa{Nome="Paulo", Casada=true, DataNascimento=new DateTime(1978,10,23)},
    new Pessoa{Nome="Maria", Casada=false, DataNascimento=new DateTime(2000,1,10)},
    new Pessoa{Nome="Carlos", Casada=false, DataNascimento=new DateTime(1999,12,12)}
};

var linq1 = from p in pessoas
            where p.Casada
            select p;
foreach (var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada);
foreach (var pessoa in linq2)
{
    Console.WriteLine(pessoa);
}

var linq3 = from p in pessoas
            where p.Casada
            select p.Nome;

var linq4 = pessoas
            .Where(p => p.Casada)
            .Select(p => p.Nome)
            .ToList();
linq4.ForEach(Console.WriteLine);

var linq5 = pessoas
            .Count(p => p.DataNascimento > new DateTime(1990,1,1));
Console.WriteLine(linq5);
