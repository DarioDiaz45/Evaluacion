public struct Rombo
{
    
    private double diagonalMayor;
    private double diagonalMenor;

    
    public double DiagonalMayor
    {
        get { return diagonalMayor; }
        set
        {
            if (value > 0)
                diagonalMayor = value;
            else
                throw new ArgumentException("La diagonal mayor debe ser mayor que 0.");
        }
    }

    public double DiagonalMenor
    {
        get { return diagonalMenor; }
        set
        {
            if (value > 0)
                diagonalMenor = value;
            else
                throw new ArgumentException("La diagonal menor debe ser mayor que 0.");
        }
    }

    
    public double Lado()
    {
        return Math.Sqrt((diagonalMayor * diagonalMayor + diagonalMenor * diagonalMenor) / 4);
    }

    public double Perimetro()
    {
        return Lado() * 4;
    }

    public double Superficie()
    {
        return (diagonalMayor * diagonalMenor) / 2;
    }

    
    public bool Validar()
    {
        return diagonalMayor > 0 && diagonalMenor > 0;
    }
}