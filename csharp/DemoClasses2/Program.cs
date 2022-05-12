int x = 10;
int y = 3;
Console.WriteLine(x/y);
Console.WriteLine(x%y);
var resultado = Math.DivRem(x,y);
Console.WriteLine(resultado);
(var q, var r) = Math.DivRem(x,y);
Console.WriteLine(q);
Console.WriteLine(r);
int quociente;
int resto = Math.DivRem(x,y,out quociente);
Console.WriteLine(quociente);
Console.WriteLine(resto);

static void swap(ref int x, ref int y)
{
    var tmp = x;
    x = y;
    y = tmp;
}

static void swapvalor(int x, int y)
{
    var tmp = x;
    x = y;
    y = tmp;
}

int a = 1;
int b = 2;
//swap(ref a, ref b);
swapvalor(a,b);
Console.WriteLine(a);
Console.WriteLine(b);