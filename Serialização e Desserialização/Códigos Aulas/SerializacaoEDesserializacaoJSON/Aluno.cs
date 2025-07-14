using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerializacaoEDesserializacaoJSON;

public class Aluno{

    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public int Idade;

    [JsonIgnore]
    public int Idade2 { get; set; }

    public int Idade3 { get; set; }

    public Aluno(){}

    public Aluno(int id, string nome, string email, int idade){
        Id = id;
        Nome = nome;
        Email = email;
        Idade = idade;
        Idade2 = idade;
        Idade3 = idade;
    }

    public override string ToString(){
        return $"Id: {Id}, Nome: {Nome}, Email: {Email}, Idade: {Idade}, Idade2: {Idade2}, Idade3: {Idade3}";
    }

}
