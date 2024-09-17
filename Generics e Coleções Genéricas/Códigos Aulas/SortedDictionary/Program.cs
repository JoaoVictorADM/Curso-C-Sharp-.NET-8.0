var brics = new SortedDictionary<int, string>(){
    {20, "Brasil"},
    {10, "China"},
    {40, "India"},
    {30, "Russia"},
    {50, "África do Sul"}
};

Console.WriteLine("Incluindo elemento usando tryAdd");

if(brics.TryAdd(60, "Argentina"))
    Console.WriteLine("Argentina adicionada");
else
    Console.WriteLine("Argentina não adicionada");

Console.WriteLine(brics.Count);

foreach(var item in brics)
    Console.WriteLine($"{item.Key} - {item.Value}");