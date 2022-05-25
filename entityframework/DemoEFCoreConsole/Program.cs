using DemoEFCoreConsole.Models;

using (var db = new FilmesDBContext())
{
    var todos = db.Filmes.OrderBy(f => f.Ano).ToList();
    todos.ForEach(f => Console.WriteLine($"{f.Id} - {f.Titulo} - {f.Ano}"));

    /*
    Filme f1 = new Filme{Titulo="Titanic", Ano=1997};
    db.Filmes.Add(f1);
    db.SaveChanges();
    */
    /*
    var umFilme = db.Filmes.Find(3);
    if (umFilme != null)
    {
        umFilme.Duracao = 30;
    }
    db.SaveChanges();
    */
    var umFilme = db.Filmes.Find(3);
    if (umFilme != null)
    {
        db.Remove(umFilme);
        db.SaveChanges();
    }

    todos = db.Filmes.OrderBy(f => f.Ano).ToList();
    todos.ForEach(f => Console.WriteLine($"{f.Id} - {f.Titulo} - {f.Ano}"));
}