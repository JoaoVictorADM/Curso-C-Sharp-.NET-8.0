using Exercicio_4;

int total = 4;
Pessoa[] pessoas = new Pessoa[total];

for(int i = 0; i < total; i++){
    Console.Write($"Insira o nome da {i}ª pessoa: ");

    string? nome = Console.ReadLine();
    pessoas[i] = new Pessoa(nome);
}

foreach(Pessoa pessoa in pessoas){
    Console.WriteLine(pessoa.ToString());
}