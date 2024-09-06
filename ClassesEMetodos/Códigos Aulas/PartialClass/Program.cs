using PartialClass;

Console.WriteLine("## Partial Class ##\n");

MinhaPartialClass minhaPartialClass = new MinhaPartialClass();

Console.WriteLine("Idade para nascidos em : 07/08/2003\n");

var idade = minhaPartialClass.calculaIdade(new DateTime(2003, 8, 7));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos");

Console.WriteLine("\nIdade para os nascidos em : 06/09/2004\n");

var data1 = DateTime.Now;
var data2 = new DateTime(2004, 10, 14);
var diferenca = minhaPartialClass.diferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Floor(diferenca.TotalDays / 365.0)} anos");

Console.ReadKey();

