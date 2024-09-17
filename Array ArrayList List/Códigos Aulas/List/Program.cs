using System.Collections;

List<string> l = new List<string>();
var l1 = new List<string>();
List<string> l2 = new();

List<string> l3 = new() {"João", "Maria"};

l.Add("Bruna");

l3.Add("Paulo");

l3.AddRange(l);

l3.Insert(2, "Ana");

l3.InsertRange(3, l);

ExibiLista(l3);

foreach(string nome in l3)
    Console.Write($"{nome} ");
Console.WriteLine();

l3.Remove("Bruna");

ExibiLista(l3);

l3.RemoveAt(4);

ExibiLista(l3);

l3.RemoveRange(0, 2);

ExibiLista(l3);

Console.WriteLine(l3.Contains("Maria"));
Console.WriteLine(l3.Contains("Ana"));

l3.Add("Amanda");

ExibiLista(l3);

l3.Sort();

ExibiLista(l3);

l3.Clear();

static void ExibiLista(List<string> l3)
{
    for(int i = 0; i < l3.Count; i++)
    {
        Console.Write($"{l3[i]} ");
    }
    Console.WriteLine();
}


ArrayList lista = new();

lista.Add(1); //boxing, converte o tipo primitivo em objeto
int teste = (int)lista[0]; //unboxing, converte o objeto em tipo primitivo

List<int> lista1 = new();
lista1.Add(1); // sem boxing

int teste1 = lista1[0]; //sem unbixing

Console.WriteLine("\n");

//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

List<string> frutas = new() { "banana", "maçã", "uva", "laranja" };

Console.WriteLine(frutas.Find(fruta => fruta.Equals("uva")));
Console.WriteLine(frutas.Find(fruta => fruta.Contains('r')));
Console.WriteLine(frutas.Find(fruta => fruta.StartsWith('m')));

Console.WriteLine();

Console.WriteLine(frutas.FindLast(fruta => fruta.Contains('n')));
Console.WriteLine(frutas.FindIndex(fruta => fruta.Contains('n')));
Console.WriteLine(frutas.FindLastIndex(fruta => fruta.Contains('n')));

Console.WriteLine();

List<string> listaStringComN = frutas.FindAll(fruta => fruta.ToLower().Contains('n'));

foreach(var item in listaStringComN)
{
    Console.Write(item + " ");
}

Console.WriteLine();