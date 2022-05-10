// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var diaHora = DateTime.Now;
Console.WriteLine(diaHora);
Console.WriteLine(diaHora.ToShortDateString());
Console.WriteLine(diaHora.ToLongDateString());
var amanha = diaHora.AddDays(1);
Console.WriteLine(amanha);