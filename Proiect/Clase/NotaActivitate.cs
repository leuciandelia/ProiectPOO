namespace Proiect.Clase;

public class NotaActivitate: Nota
{
    public NotaActivitate(double valoare)
    {
        Valoare = valoare;
        Tip = "Activitate";
    }

    public override bool EsteValida()
    {
        return Valoare>=1 && Valoare<=10; 
    }
}