using Exercicio6;

try
{
    int saldo = 0;
    int valorSaque = 100;
    if (valorSaque > saldo)
    {
        throw new SaldoInsuficienteException("O saldo é insuficiente para este saque.");
    }
    saldo -= valorSaque;
    Console.WriteLine("Saque efetuado com sucesso. Novo saldo: " + saldo);
}
catch (SaldoInsuficienteException e)
{
    Console.WriteLine("Erro: " + e.Message);
}