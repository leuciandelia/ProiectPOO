using Proiect.Clase;

namespace Proiect;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Andrei Popa");

        var disciplinaObligatorie = new DisciplinaObligatorie("Analiza Matematica", 1, 1);
        disciplinaObligatorie.Note.Add(new NotaExamen(9));
        disciplinaObligatorie.Note.Add(new NotaActivitate(6));
        
        var disciplinaOptionala=new DisciplinaObligatorie("TS2", 1, 1);
        disciplinaOptionala.Note.Add(new NotaActivitate(7));
        
        student.InroleazaDisciplina(disciplinaObligatorie);
        student.InroleazaDisciplina(disciplinaOptionala);
        
        student.VizualizareNote();
        Console.WriteLine($"Media Anuala:{student.CalculeazaMediaAnuala(1)}");
        
        
        
        
    }
}