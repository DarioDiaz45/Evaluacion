using ConsoleTables;
using System;
const int MaxRombos = 10;
Rombo[] rombo = new Rombo[MaxRombos];
int Count = 0;

int opcion;
do
{
    
    Console.WriteLine("Menu de opciones:");
    Console.WriteLine("1- Ingresar Rombos:");
    Console.WriteLine("2- Mostrar todos los rombos");
    Console.WriteLine("3- Modificar un rombo");
    Console.WriteLine("4- Mostrar estadisticas de un rombo");
    Console.WriteLine("5- Mostrar rombos con superficies superiores al promedio");
    Console.WriteLine("6- Salir");
    Console.WriteLine("Seleccione una opcion!!");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            IngresarRombo();
            break;
        case 2:
            MostrarRombos();
            break;
        case 3:
            ModificarRombo();
            break;
        case 4:
            EstadisticasRombo();
            break;
        case 5:
            SuperficiesSuperiores();
            break;
        case 6:
            Console.WriteLine("Salir del programa!!");
            break;
        default:
            Console.WriteLine("Opcion no valida . Intentar de nuevo!!");
            break;
    }
} while (opcion != 6);

void SuperficiesSuperiores()
{
    if (Count == 0)
    {
        Console.WriteLine("No hay rombos para analizar.");
        return;
    }

    double sumaSuperficies = 0;

    for (int i = 0; i < Count; i++)
    {
        sumaSuperficies += rombo[i].Superficie();
    }

    double promedioSuperficie = sumaSuperficies / Count;

    Console.WriteLine($"\nRombos con superficie superior al promedio ({promedioSuperficie:F2}):");

    var table = new ConsoleTable("Index", "Diagonal Mayor", "Diagonal Menor", "Lado", "Perímetro", "Superficie");

    for (int i = 0; i < Count; i++)
    {
        if (rombo[i].Superficie() > promedioSuperficie)
        {
            table.AddRow(i, rombo[i].DiagonalMayor, rombo[i].DiagonalMenor, rombo[i].Lado(), rombo[i].Perimetro(), rombo[i].Superficie());
        }
    }

    table.Write();
}


void EstadisticasRombo()
{
    if (Count == 0)
    {
        Console.WriteLine("No hay rombos para mostrar estadísticas.");
        return;
    }

    double maxSuperficie = double.MinValue;
    double minSuperficie = double.MaxValue;
    double sumaSuperficies = 0;
    int maxIndex = 0, minIndex = 0;

    for (int i = 0; i < Count; i++)
    {
        double superficie = rombo[i].Superficie();

        if (superficie > maxSuperficie)
        {
            maxSuperficie = superficie;
            maxIndex = i;
        }

        if (superficie < minSuperficie)
        {
            minSuperficie = superficie;
            minIndex = i;
        }

        sumaSuperficies += superficie;
    }

    double promedioSuperficie = sumaSuperficies / Count;

    Console.WriteLine($"Estadísticas:");
    Console.WriteLine($"Mayor superficie: {maxSuperficie} (Rombo en índice {maxIndex})");
    Console.WriteLine($"Menor superficie: {minSuperficie} (Rombo en índice {minIndex})");
    Console.WriteLine($"Promedio de superficies: {promedioSuperficie}");
}

void ModificarRombo()
{
    Console.WriteLine($"Ingrese el indice del rombo a modificar(0 a {0})");
    int Index = Convert.ToInt32(Console.ReadLine());
    if(Index<0|| Index >= Count)
    {
        Console.WriteLine("Indice fuera de rango . Intente de nuevo!!");
        return;
    }
    try
    {
        Console.WriteLine("Ingrese el nuevo valor de la diagonal mayor (DM):");
        double DM = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el nuevo valor de la diagonal menor (dm): ");
        double dm = Convert.ToDouble(Console.ReadLine());
        rombo[Index].DiagonalMayor = DM;
        rombo[Index].DiagonalMenor = dm;
        Console.WriteLine("Rombo modificado correctamente.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void MostrarRombos()
{
    if (Count == 0)
    {
        Console.WriteLine("No hay rombos para mostrar!!");
        return;
    }
    var table = new ConsoleTable ("Index", "Diagonal Mayor", "Diagonal Menor", "Lado", "Perímetro", "Superficie");
    for (int i = 0; i < Count; i++)
    {
        table.AddRow(i, rombo [i].DiagonalMayor, rombo [i].DiagonalMenor, rombo [i].Lado(), rombo[i].Perimetro(), rombo[i].Superficie());
    }

    table.Write();
}

void IngresarRombo()
{
    if (Count > MaxRombos)
    {
        Console.WriteLine("El array de rombos esta lleno!!");
        return;
    }
    try
    {
        Console.WriteLine("Ingrese el valor de la diagonal mayor (DM): ");
        double DM = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el valor de la diagonal menor (dm): ");
        double dm = Convert.ToDouble(Console.ReadLine());
        rombo[Count] = new Rombo { DiagonalMayor = DM, DiagonalMenor = dm };
        Count++;
        Console.WriteLine("Rombo ingresado correctamente");

    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}