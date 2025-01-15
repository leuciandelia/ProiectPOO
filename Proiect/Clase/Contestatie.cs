namespace Proiect.Clase;

public class Contestatie
{
    public Nota NotaContestata { get; private set; }
    public string Motiv{get; private set;}
    public string Stare {get; private set;}

    public Contestatie(Nota nota, string motiv)
    {
        NotaContestata = nota;
        Motiv = motiv;
        Stare = "in asteptare";
    }

    public void RezolvaContestaia(bool aprobat, double valoareNoua = 0)
    {
        if (aprobat && valoareNoua > 0)
        {
            NotaContestata.Valoare = valoareNoua;
        }

        if (aprobat)
        {
            Stare = "Aprobata";
        }
        else
        {
            {
                Stare = "Respinsa";
            }
        }
    }

    public void AfiseazaStare()
        {
            Console.WriteLine($"Nota: {NotaContestata.Valoare},Stare: {Stare}, Motiv: {Motiv}");
        }
 }