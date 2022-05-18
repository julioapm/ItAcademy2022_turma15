using System.ComponentModel.DataAnnotations;
public class Pizza
{
    public int Id {get;set;}
    [StringLength(20)]
    public string Name {get;set;} = null!;
    public bool IsGlutenFree {get;set;}
    public decimal Price {get;set;}
    public override string ToString()
    {
        return base.ToString() + $"{Id}, {Name}, {IsGlutenFree}, {Price}";
    }
}