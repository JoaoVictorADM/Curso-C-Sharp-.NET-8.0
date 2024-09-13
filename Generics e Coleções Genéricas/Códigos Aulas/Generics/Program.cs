//int
int i1 = 10;
int i2 = 10;

//float
float f1 = 10;
float f2 = 10;
//string

string s1 = "10";
string s2 = "10";

Teste<int, int> teste1 = new Teste<int, int>();
Teste<float, float> teste2 = new Teste<float, float>();
Teste<string, string> teste3 = new Teste<string, string>();

teste1.Comparar(i1, i2);
teste2.Comparar(f1, f2);
teste3.Comparar(s1, s2);

Console.ReadKey();
public class Teste<T1, T2>{
    public void Comparar(T1 p1, T2 p2){
        var resultado = p1?.Equals(p2);
        Console.WriteLine($" Os tipos : {p1?.GetType()} e {p2?.GetType()}");
        Console.WriteLine($" {p1} e {p2} são iguais ? {resultado}\n");
    }
}