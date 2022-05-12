public class Bomba
{
    public bool Explodiu {get; private set;}
    private int tics;
    public int TempoLimite {get; init;}
    public event EventHandler FezBum;

    public Bomba(int tempoLimite)
    {
        TempoLimite = tempoLimite;
    }

    public void Tic()
    {
        tics++;
        if (tics > TempoLimite && !Explodiu)
        {
            Explodiu = true;
            //Disparar evento
            if (FezBum != null)
            {
                FezBum(this,EventArgs.Empty);
            }
        }
    }
}