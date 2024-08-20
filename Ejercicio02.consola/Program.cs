Rombo[] rombos = new Rombo[5];
double maxSuperficie = 0;
int maxSuperficieIndex = 0;
double sumaPerimetros = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Ingreso de datos para el rombo {i + 1}:");

    double DM, dm;
    do
    {
        Console.Write("Ingrese el valor de la diagonal mayor (DM): ");
        DM = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de la diagonal menor (dm): ");
        dm = Convert.ToDouble(Console.ReadLine());

        if (DM <= 0 || dm <= 0)
        {
            Console.WriteLine("Error: Las diagonales deben ser mayores a 0. Por favor, intente de nuevo.");
        }
    }
    while (DM <= 0 || dm <= 0);

    rombos[i] = new Rombo(DM, dm);

    if (rombos[i].Superficie > maxSuperficie)
    {
        maxSuperficie = rombos[i].Superficie;
        maxSuperficieIndex = i;
    }

    sumaPerimetros += rombos[i].Perimetro;
}

double promedioPerimetros = sumaPerimetros / 5;

Console.WriteLine($"El rombo de mayor tamaño fue el ingresado en la iteración {maxSuperficieIndex + 1} con una superficie de {maxSuperficie}");
Console.WriteLine($"El promedio de los perímetros de los rombos ingresados es: {promedioPerimetros}");
    