public class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(string umNome, int umaIdade)
    {
        nome = umNome;
        idade = umaIdade;
    }

    public Pessoa(string umNome) : this(umNome,0)
    {
    }

    public string Nome => nome;
    /*
    public string Nome
    {
        get
        {
            return nome;
        }
    }
    */

    public int Idade
    {
        get => idade;
        set => idade = value;
        /*
        get
        {
            return idade;
        }
        set
        {
            idade = value;
        }
        */
    }
}