Random r = new();

for (int i = 0; i < 10; i++){

    Console.WriteLine(r.Next());
    Console.WriteLine(r.Next());
    Console.WriteLine(r.Next(2));
    Console.WriteLine(r.NextDouble() * 10 - 5);
    Console.WriteLine(r.Next(0, 2) + "\n");

    r = new((r.Next() * i) + (r.Next() % (i+1)));
}

byte[] randBytes = new byte[5];

r.NextBytes(randBytes);

foreach(byte b in randBytes)
    Console.Write(b + " ");
Console.WriteLine();