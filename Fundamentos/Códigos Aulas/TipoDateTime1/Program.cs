Console.WriteLine("## Struct DateTime ##\n");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

// Criando data específica

Console.WriteLine("\n--------------------------------------------\n");

DateTime novaData = new DateTime(2004, 10, 14);

Console.WriteLine(novaData);

DateTime novaDataComHorario = new DateTime(2004, 10, 14, 12, 30, 15);

Console.WriteLine("\n--------------------------------------------\n");

Console.WriteLine(novaDataComHorario);

// Extraindo informações da data atual

Console.WriteLine("\n--------------------------------------------\n");

DateTime dataTeste = DateTime.Now;

Console.WriteLine(dataTeste.Year);
Console.WriteLine(dataTeste.Month);
Console.WriteLine(dataTeste.Day);
Console.WriteLine(dataTeste.Hour);
Console.WriteLine(dataTeste.Minute);
Console.WriteLine(dataTeste.Millisecond);
Console.WriteLine(dataTeste.DayOfWeek);
Console.WriteLine(dataTeste.DayOfYear);

// Data no formato longo e curto

Console.WriteLine("\n--------------------------------------------\n");

Console.WriteLine(dataTeste.ToLongDateString());
Console.WriteLine(dataTeste.ToShortDateString());
Console.WriteLine(dataTeste.ToLongTimeString());
Console.WriteLine(dataTeste.ToShortTimeString());

// Adicionando valores a data atual

Console.WriteLine("\n--------------------------------------------\n");

Console.WriteLine(dataTeste.AddYears(1));
Console.WriteLine(dataTeste.AddMonths(1));
Console.WriteLine(dataTeste.AddDays(1));
Console.WriteLine(dataTeste.AddHours(1));
Console.WriteLine(dataTeste.AddMinutes(1));
Console.WriteLine(dataTeste.AddMilliseconds(1));

// Interpolação de string

Console.WriteLine("\n--------------------------------------------\n");

Console.WriteLine($"A data atual é {dataAtual}");