namespace Proiect.Clase;

public abstract class Nota
{
    public double Valoare { get; set; }
    public string Tip { get; set; }

    public abstract bool EsteValida();

}