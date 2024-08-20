Rombo rombo = new Rombo();
try
{
    Console.WriteLine("Ingrese el valor de la diagonal mayor del rombo(DM):");
    rombo.DiagonalMayor =Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el valor de la diagonal menor del rombo(dm):");
    rombo.DiagonalMenor = Convert.ToDouble(Console.ReadLine());
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    return;
}
Console.WriteLine("-----RESULTADOS-----");
Console.WriteLine($"Lado del rombo: {rombo.Lado()}");
Console.WriteLine($"Perímetro del rombo: {rombo.Perimetro()}");
Console.WriteLine($"Superficie del rombo: {rombo.Superficie()}");
