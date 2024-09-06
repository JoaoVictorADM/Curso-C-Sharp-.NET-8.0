using Joao.Teste;

Aluno aluno = new Aluno();
Curso curso = new Curso();

Joao.Curso.Aluno.exibir();

Console.ReadKey();

namespace Joao.Teste{
    public class Aluno{ 

    }
    public class Curso{ 

    }
}
namespace Joao.Curso{
    public class Aluno{
        public static void exibir(){
            Console.WriteLine("Método Exibir - classe Demo.Aluno");
        }
    }
}
