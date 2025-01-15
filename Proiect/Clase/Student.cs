namespace Proiect.Clase;

public class Student
{
    public string Nume { get; private set; }
    public List<Disciplina> Discipline { get; private set; }

    public Student(string nume)
    {
        Nume = nume; 
        Discipline = new List<Disciplina>();
    }

    public void InroleazaDisciplina(Disciplina disciplina)
    {
        Discipline.Add(disciplina);
    }

    public void VizualizareNote()
    {
        foreach (var disciplina in Discipline)
        {
            disciplina.PublicaNote();
        }
    }

    public double CalculeazaMedieDisciplina(Disciplina disciplina)
    {
        if (disciplina.Note.Count == 0)
            return 0;//daca nu exista note returneaza 0
        double sumaNote = 0;
        foreach (var nota in disciplina.Note)
        {
            sumaNote += nota.Valoare;//aduna valorile notelor
        }

        return sumaNote/disciplina.Note.Count;//calculeaza media
    }

    public double CalculeazaMediaAnuala(int anStudiu)
    {
        //filtram disciplinele pentru anul specificat
        var disciplineAn=new List<Disciplina>();
        foreach (var disciplina in Discipline)
        {
            if (disciplina.AnStudiu == anStudiu)
            {
                disciplineAn.Add(disciplina);//adaugam disciplina in lista filtrata
            }
        }

        if (disciplineAn.Count == 0)
        {
            return 0;//daca nu exista discipline in anul respectiv returnam 0
        }

        double sumaMedii = 0;
        foreach (var disciplina in disciplineAn)
        {
            sumaMedii+=CalculeazaMedieDisciplina(disciplina);//aduna media fiecarei discipline
        }
        return sumaMedii/disciplineAn.Count;//calculeaza media anuala
    }

    public double CalculeazaMediaMultianuala()
    {
        if (Discipline.Count == 0)
        {
            return 0;//daca nu exista discipline returnam 0
        }

        double sumaMedii = 0;
        foreach (var disciplina in Discipline)
        {
            sumaMedii+=CalculeazaMedieDisciplina(disciplina);//aduna media fiecarei discipline
        }
        return sumaMedii/Discipline.Count;//calculeaza media multianuala
    }
}