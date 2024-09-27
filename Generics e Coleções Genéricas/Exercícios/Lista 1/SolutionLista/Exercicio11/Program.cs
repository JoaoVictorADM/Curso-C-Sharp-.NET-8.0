Random random = new Random();
Queue<string> filaImpressao = new Queue<string>();


for(int i = 0; i < 10; i++)
    filaImpressao.Enqueue($"Documento {i + 1}");

while(filaImpressao.Count > 0){

    
    string impressao = filaImpressao.Dequeue();

    Console.WriteLine($"Imprimindo {impressao}");
    Thread.Sleep(random.Next(1000, 5001));
    Console.WriteLine("Impressão Concluída\n");

}