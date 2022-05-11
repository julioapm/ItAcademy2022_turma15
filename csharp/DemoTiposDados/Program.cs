using System.Text;

int x = 1;
int y = x; //cópia de valor
x = x + 1;
Console.WriteLine(x);
Console.WriteLine(y);

string s1 = "teste";
string s2 = s1; //cópia de referência
s1 = s1 + " alterado";
Console.WriteLine(s1);
Console.WriteLine(s2);

StringBuilder sb1 = new StringBuilder("teste");
StringBuilder sb2 = sb1; //cópia de referência
sb1.Append(" alterado");
Console.WriteLine(sb1);
Console.WriteLine(sb2);
