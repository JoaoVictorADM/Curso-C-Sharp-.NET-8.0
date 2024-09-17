using Exercicio_3;

int total = 4;
Pessoa[] pessoas = new Pessoa[total];

for(int i = 0; i < total; i++){
    Console.Write($"Insira o nome da {i}ª pessoa (Pares Professores): ");
    string? nome = Console.ReadLine();

    pessoas[i] = i % 2 == 0 ? new Professor(nome) : new Aluno(nome);
}

for(int i = 0; i < total; i++){

    if(pessoas[i] is Professor){
        ((Professor)pessoas[i]).Explicar();
        continue;
    }

    ((Aluno)pessoas[i]).Estudar();

}
