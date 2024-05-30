Console.WriteLine("## Tipos de Referência Anuláveis ##\n");

/* Isso dá erro

string nome = null;
Console.WriteLine(nome.ToUpper());

*/

string? nome = null;

Console.WriteLine(nome?.ToUpper());

string nome1 = "";
Console.WriteLine(nome1.ToUpper());