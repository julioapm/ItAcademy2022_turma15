public abstract class FiguraGeometrica : IComparable<FiguraGeometrica>
{
    public int X {get;set;}
    public int Y {get;set;}
    public string Id{get;init;}
    public abstract int Area {get;}

    public FiguraGeometrica(int x, int y, string id)
    {
        X = x;
        Y = y;
        Id = id;
    }

    public override string ToString()
    {
        return base.ToString() + $"[X={X}, Y={Y}, Id={Id}]";
    }

    public int CompareTo(FiguraGeometrica? other)
    {
        if (other == null) return 1;
        return Area.CompareTo(other.Area);
    }

    public class ComparadorPorPontoCartesiano : IComparer<FiguraGeometrica>
    {
        public int Compare(FiguraGeometrica? fig1, FiguraGeometrica? fig2)
        {
            if (fig1 == null)
            {
                if (fig2 == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (fig2 == null)
                {
                    return 1;
                }
                else
                {
                    //comparar os pontos de cada figura
                    if (fig1.X < fig2.X)
                    {
                        return -1;
                    }
                    else if (fig1.X > fig2.X)
                    {
                        return 1;
                    }
                    else
                    {
                        if (fig1.Y < fig2.Y)
                        {
                            return -1;
                        }
                        else if (fig1.Y > fig2.Y)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}