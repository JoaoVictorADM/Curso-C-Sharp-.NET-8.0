/*
 
7 - Crie um indexador para uma classe Aluno para gerenciar uma coleção de nomes de alunos com no máximo
10 elementos.

Para testar a implementação atribua nomes e obtenha os valores atribuídos usando o indexador criado. 
 
*/

Aluno a = new Aluno();

a[0] = "Maria";
a[1] = "João";
a[2] = "Pedro";
a[10] = "Ana";

public class Aluno{

    string[] nomes = new string[10];

    public string this[int index]{

        get{ 
        
            if(index < 0 || index >= nomes.Length)
                return "Indice fora dos limites";

            return nomes[index];
        }

        set{

            if (index < 0 || index >= nomes.Length){
                Console.WriteLine($"Indice [{index}] fora dos limites");
                return;
            }
                

            nomes[index] = value;

        }

    }

}
