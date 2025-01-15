namespace Proiect.Clase;

public abstract class Disciplina
{
    public string Nume { get; set; }
    public int AnStudiu { get; set; }
    public int Semestru { get; set; }
    public List<Nota>Note { get; set; }

    public Disciplina(string nume, int anStudiu, int semestru)
    {
        Nume = nume;
        AnStudiu = anStudiu;
        Semestru = semestru;
        Note = new List<Nota>();
    }

public abstract bool CombinaNotele(List<Nota> note);
public abstract void PublicaNote();
}