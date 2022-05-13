public abstract class FiguraGeometrica
{
    public int X {get;set;}
    public int Y {get;set;}

    public abstract int Area {get;}

    public FiguraGeometrica(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return base.ToString() + $"[X={X}, Y={Y}]";
    }
}