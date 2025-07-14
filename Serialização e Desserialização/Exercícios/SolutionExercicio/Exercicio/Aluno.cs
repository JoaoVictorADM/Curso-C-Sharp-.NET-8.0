using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio;

public class Aluno{

    public int Id { get; set; }
    public string Nome { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public int Idade { get; set; }

    public Aluno() {}

    public Aluno(int id, string nome, string email, int idade){
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }

}
