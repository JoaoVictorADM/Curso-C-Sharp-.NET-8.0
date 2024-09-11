namespace Agregacao;
public class Departamento{
    public string? Nome { get; set; }
    private List<Professor>? professores { get; set; }

    public Departamento(string? Nome){
        this.Nome = Nome;
        this.professores = new List<Professor>();
    }
    public void IncluirProfessor(Professor professor){
        this.professores?.Add(professor);
    }
    public void ListaProfessores(){
        Console.WriteLine($"\nDepartamento de : {this.Nome}\n");

        foreach(var prof in this.professores)
            Console.WriteLine(prof.Nome + " -> " + prof.Disciplina);
    }

}
