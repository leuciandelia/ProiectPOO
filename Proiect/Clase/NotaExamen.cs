namespace Proiect.Clase;

public class NotaExamen: Nota
{
    public NotaExamen(double valoare)
    {
        Valoare = valoare;
        Tip = "Examen";
    }

    public override bool EsteValida()
    {
        return Valoare>=1 && Valoare<=10;
    }
}