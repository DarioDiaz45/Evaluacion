Console.Write("Ingrese el valor de la diagonal mayor del rombo: ");
double DM=Convert.ToDouble(Console.ReadLine());
Console.Write("Ingreser el valor de la diagonal menor del rombo: ");
double dm=Convert.ToDouble(Console.ReadLine());
double lado = Math.Sqrt((DM * DM + dm * dm) / 4);
double perimetro = lado * 4;
double superficie = (DM * dm) / 2;
Console.WriteLine("------RESULTADOS------");
Console.WriteLine($"El valor del lado del rombo es: {lado} ");
Console.WriteLine($"El valor del perimetro del rombo es: {perimetro} ");
Console.WriteLine($"El valor de la superficie del rombo es: {superficie} ");


