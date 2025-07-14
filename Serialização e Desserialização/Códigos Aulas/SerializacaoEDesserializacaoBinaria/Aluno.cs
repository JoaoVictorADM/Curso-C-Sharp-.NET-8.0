using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacaoEDesserializacaoBinaria;

[Serializable]
public class Aluno{

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    [NonSerialized]
    public int Idade;

    public Aluno(int id, string nome, string email, int idade){
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public override string ToString(){
        return $"Id: {Id}, Nome: {Nome}, Email: {Email}, Idade: {Idade}";
    }

}
