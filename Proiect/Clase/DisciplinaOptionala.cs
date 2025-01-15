namespace Proiect.Clase;

public class DisciplinaOptionala : Disciplina
{
    public DisciplinaOptionala(string nume, int anStudiu,int semestru): base(nume,anStudiu,semestru) { }

    public override bool CombinaNotele(List<Nota> note)
    {
        foreach (var n in note)
        {
            if (!(n is NotaActivitate))
            {
                return false;
            }
        }

        return true;
    }

    public override void PublicaNote()
    {
        foreach (var nota in Note)
        {
            Console.WriteLine($"{Nume} (Optionala) - {nota.Tip}:{nota.Valoare}");
        }
    }
}