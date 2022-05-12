static void OuvirExplosao(object? sender, EventArgs e)
{
    Console.WriteLine("A bomba fez Bum!");
}

Bomba b = new Bomba(3);
b.FezBum += OuvirExplosao;
b.Tic();
Console.WriteLine("tic");
b.Tic();
Console.WriteLine("tic");
b.Tic();
Console.WriteLine("tic");
b.Tic(); //Explodiu!
Console.WriteLine("tic");
