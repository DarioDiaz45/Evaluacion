internal class Rombo
{
    public double DiagonalMayor { get; set; }
    public double DiagonalMenor { get; set; }
    public double Lado { get; set; }
    public double Perimetro { get; set; }
    public double Superficie { get; set; }

    public Rombo(double diagonalMayor, double diagonalMenor)
    {
        DiagonalMayor = diagonalMayor;
        DiagonalMenor = diagonalMenor;
        Lado = Math.Sqrt((DiagonalMayor * DiagonalMayor + DiagonalMenor * DiagonalMenor) / 4);
        Perimetro = Lado * 4;
        Superficie = (DiagonalMayor * DiagonalMenor) / 2;
    }
}