/*
7 - Suponha que você possui uma lista de planetas com informações sobre o nome, diâmetro e massa de cada
planeta.

Crie um programa e implemente um método que recebe essa lista e um delegate Predicate<Planeta> para
filtrar os planetas de acordo com um critério específico.
*/

using Exercicio7;

public class Program{

    public static void Main(string[] args){

        Predicate<Planeta> filtroPlaneta = (Planeta p) => p.Diametro > 100000.0;

        List<Planeta> planetas = new List<Planeta>{
            new Planeta { Nome = "Terra",   Diametro = 12742.4, Massa = 5.97 },
            new Planeta { Nome = "Marte",   Diametro = 6779.1,  Massa = 0.642 },
            new Planeta { Nome = "Jupiter", Diametro = 139820.7, Massa = 1898 },
            new Planeta { Nome = "Saturno", Diametro = 116460.4, Massa = 568 }
        };

        foreach(var planeta in planetas){
            if(filtroPlaneta.Invoke(planeta)){
                Console.WriteLine($"Planeta: {planeta.Nome}, Diâmetro: {planeta.Diametro}, Massa(10^24kg)): {planeta.Massa}");
            }
        }

    }

}
