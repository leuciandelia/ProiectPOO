namespace Proiect.Clase;

public class Student
{
    public string Nume { get; set; }
    public int AnStudiu { get; set; }
    public List<Disciplina> Discipline { get; set; }

    public Student(string nume, int anStudiu)
    {
        Nume = nume;
        AnStudiu = anStudiu;
        Discipline = new List<Disciplina>();
    }
    
}