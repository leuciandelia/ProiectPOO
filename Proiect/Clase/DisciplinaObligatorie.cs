namespace Proiect.Clase;

public class DisciplinaObligatorie : Disciplina
{
    public DisciplinaObligatorie(string nume,int anStudiu,int semestru):base(nume,anStudiu,semestru){ }

    public override bool CombinaNotele(List<Nota> note)
    {
        foreach (var n in note)
        {
            if (!n.EsteValida())
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
            Console.WriteLine($"{Nume}-{nota.Tip}:{nota.Valoare}");
        }
    }
}